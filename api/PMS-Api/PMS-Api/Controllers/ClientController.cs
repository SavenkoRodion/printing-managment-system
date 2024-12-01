using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Enums;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
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

    [HttpPost("create")]
    public async Task<IActionResult> CreateClientAsync([FromBody] CreateClientRequest request, CancellationToken cancellationToken)
    {
        var result = await repository.CreateClientAsync(request.ClientName, request.ClientEmail, request.ClientAddress, cancellationToken);

        return result switch
        {
            CreateClientResult.Success => Ok(),
            CreateClientResult.Duplicate => Conflict(),
            CreateClientResult.Failure => Problem(),
            _ => Problem()
        };
    }

    [HttpDelete("{clientId}")]
    public async Task<bool> DeleteAsync([FromRoute] Guid clientId, CancellationToken cancellationToken)
    {
        return await repository.DeleteAsync(clientId, cancellationToken);
    }

    [HttpPut("edit")]
    public async Task<IActionResult> EditAsync([FromBody] EditClientRequest request, CancellationToken cancellationToken)
    {
        return await repository.EditAsync(request.Uuid, request.Name, request.Email, request.Address, cancellationToken) ? Ok() : Problem();
    }
}
