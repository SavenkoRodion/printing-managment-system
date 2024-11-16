using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
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
}
