using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using PMS_Api.Repository;


namespace PMS_Api.Controllers;

[Authorize]
[Route("api/pattern")]
[ApiController]
public class PatternController(IPatternRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IReadOnlyList<Pattern>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pattern>> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var pattern = await repository.GetByIdAsync(id, cancellationToken);
        if (pattern == null)
        {
            return NotFound();
        }
        return Ok();
    }
}
