using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Repository;

namespace PMS_Api.Controllers;

[Authorize]
[Route("api/client")]
[ApiController]
public class ClientController(IClientRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IReadOnlyList<Client>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var client = await repository.GetByIdAsync(id, cancellationToken);
        if (client == null)
        {
            return NotFound();
        }
        return Ok();
    }
}
