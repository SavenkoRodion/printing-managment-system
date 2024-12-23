using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using PMS_Api.Repository;


namespace PMS_Api.Controllers;

[Authorize]
[Route("api/project")]
[ApiController]
public class ProjectController(IProjectRepository repository, IUserRepository<Admin> adminRepository) : ControllerBase
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
        return Ok(project);
    }


    [HttpPost]
    public async Task<ActionResult<Project>> CreateProjectAsync([FromBody] CreateProjectRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Project data is required.");
        }


        var project = new Project
        {
            Name = request.Name,
            ClientId = request.ClientId,
            ProjectTypeId = request.ProjectTypeId,
            Format = request.Format,
            LiczbaStron = 0,
            DateModified = DateTime.Now,
            AdminId = Guid.Parse(HttpContext.User.Claims.Where(x => x.Type == "Uuid").Single().Value)
        };

        var createdProject = await repository.AddProjectAsync(project, cancellationToken);

        if (createdProject == null)
        {
            return Problem();
        }

        var projectWithRelations = await repository.GetByIdAsync(createdProject.Id, cancellationToken);

        if (projectWithRelations == null)
        {
            return Problem();
        }

        return Ok(projectWithRelations);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Project>> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var project = await repository.GetByIdAsync(id, cancellationToken);
        if (project == null)
        {
            return NotFound();
        }
        await repository.DeleteAsync(project, cancellationToken);
        return NoContent();
    }

    [HttpPut("edit")]
    public async Task<IActionResult> EditAsync([FromBody] EditProjectRequest request, CancellationToken cancellationToken)
    {
        var result = await repository.EditAsync(request, cancellationToken);
        return result ? Ok() : Problem();
    }
}
