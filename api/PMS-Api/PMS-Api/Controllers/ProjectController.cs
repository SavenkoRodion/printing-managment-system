using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Repository;

namespace PMS_Api.Controllers;

[Authorize]
[Route("api/project")]
[ApiController]
public class ProjectController(IProjectRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IReadOnlyList<Project>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var project = await repository.GetByIdAsync(id, cancellationToken);
        if (project == null)
        {
            return NotFound();
        }
        return Ok();
    }
}
