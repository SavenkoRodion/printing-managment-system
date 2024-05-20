using Microsoft.AspNetCore.Mvc;
using PMS_Api.Helpers;
using PMS_Api.Interfaces;
using PMS_Api.Model.Db.Scaffold;
using PMS_Api.Model.Requests;
using PMS_Api.Services;

namespace PMS_Api.Controllers;

[ApiController]
[Route("User")]
public class UserController(IAuthenticationService authenticationService, IUserRepository<Admin> userRepository) : ControllerBase
{
    [HttpPost("Authenticate")]
    public async Task<IActionResult> Authenticate([FromBody] AuthenticateAdminRequest request, CancellationToken cancellationToken)
    {
        var response = await authenticationService.AuthenticateAdmin(request, cancellationToken);

        if (response == null)
            return BadRequest(new { message = "Username or password is incorrect" });

        return Ok(response);
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var users = await userRepository.GetAll(cancellationToken);
        return Ok(users);
    }
}
