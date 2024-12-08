using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using PMS_Api.Repository;


namespace PMS_Api.Controllers;

[Authorize]
[Route("api/template")]
[ApiController]
public class TemplateController(ITemplateRepository repository) : ControllerBase
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


        var template = new Template
        {
            Name = request.Name,
            ClientId = request.ClientId,
            ProductId = request.ProductId,
            Format = request.Format,
            LiczbaStron = 0,
            DateModified = DateTime.Now,
            AdminId = Guid.Parse(HttpContext.User.Claims.Where(x => x.Type == "Uuid").Single().Value)
        };

        var createdTemplate = await repository.AddTemplateAsync(template, cancellationToken);

        if (createdTemplate == null)
        {
            return Problem();
        }

        var templateWithRelations = await repository.GetByIdAsync(createdTemplate.Id, cancellationToken);

        if (templateWithRelations == null)
        {
            return Problem();
        }

        return Ok(templateWithRelations);
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

    [HttpPut("edit")]
    public async Task<IActionResult> EditAsync(EditTemplateRequest request, CancellationToken cancellationToken)
    {
        var result = await repository.EditAsync(request, cancellationToken);
        return result ? Ok() : Problem();
    }
}
