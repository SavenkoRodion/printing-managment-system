using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using PMS_Api.Repository;

namespace PMS_Api.Controllers;

[Authorize]
[Route("api/projectType")]
[ApiController]
public class ProjectTypeController(IProjectTypeRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IReadOnlyList<ProjectType>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }

    [HttpPost]
    public async Task<bool> CreateAsync([FromBody] CreateProjectTypeRequest request, CancellationToken cancellationToken)
    {
        return await repository.CreateAsync(request.ProjectTypeName, cancellationToken);
    }

    [HttpDelete("{projectTypeId}")]
    public async Task<bool> DeleteAsync([FromRoute] int projectTypeId, CancellationToken cancellationToken)
    {
        return await repository.DeleteAsync(projectTypeId, cancellationToken);
    }

    [HttpPut("rename")]
    public async Task<IActionResult> RenameAsync([FromBody] ReplaceProjectTypeRequest request, CancellationToken cancellationToken)
    {
        return await repository.RenameAsync(request.Name, request.Id, cancellationToken) ? Ok() : Problem();
    }
}
