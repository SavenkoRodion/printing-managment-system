using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using PMS_Api.Repository;


namespace PMS_Api.Controllers;

[Authorize]
[Route("api/template")]
[ApiController]
public class TemplateController(ITemplateRepository repository, IUserRepository<Admin> adminRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IReadOnlyList<Template>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Template>> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var template = await repository.GetByIdAsync(id, cancellationToken);
        if (template == null)
        {
            return NotFound();
        }
        return Ok(template);
    }


    [HttpPost]
    public async Task<ActionResult<Template>> CreateTemplateAsync([FromBody] CreateTemplateRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Template data is required.");
        }

        var admin = await adminRepository.GetByUuidAsync(HttpContext.User.Claims.Where(x => x.Type == "Uuid").Single().Value, cancellationToken);
        if (admin == null)
        {
            return BadRequest("Admin not found.");
        }else{
            
            var template = new Template
            {
                Name = request.Name,
                ClientId = request.ClientId,
                ProductId = request.ProductId,
                Format = request.Format,
                LiczbaStron = 0,
                DateModified = DateTime.Now,
                AdminId = admin.Uuid
            };

            var createdTemplate = await repository.AddTemplateAsync(template, cancellationToken);

            var templateWithRelations = await repository.GetByIdAsync(createdTemplate.Id, cancellationToken);
            
            if (templateWithRelations == null)
            {
                return NotFound();
            }
            return templateWithRelations;
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Template>> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var template = await repository.GetByIdAsync(id, cancellationToken);
        if (template == null)
        {
            return NotFound();
        }
        await repository.DeleteAsync(template, cancellationToken);
        return NoContent();
    }
}
