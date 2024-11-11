using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
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
        return Ok(project);
    }


    [HttpPost]
    public async Task<ActionResult<Project>> CreateProjectAsync([FromBody] CreateProjectRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Project data is required.");
        }

        try
        {
            var project = new Project
            {
                Name = request.Name,
                ClientId = request.ClientId,
                ProductId = request.ProductId,
                Format = request.Format,
                LiczbaStron = request.LiczbaStron,
                DateModified = DateTime.Now,
                AdminId = request.AdminId
            };

            var createdProject = await repository.AddProjectAsync(project, cancellationToken);

            var projectWithRelations = await repository.GetByIdAsync(createdProject.Id, cancellationToken);
            
            if (projectWithRelations == null)
            {
                return NotFound();
            }
            return projectWithRelations;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error creating project: {ex.Message}");
            return StatusCode(500, "An error occurred while creating the project.");
        }
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
}
