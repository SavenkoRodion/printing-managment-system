using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.Db.Scaffold;
using PMS_Api.Model.Requests;
using PMS_Api.Services;
using System.Security.Claims;

namespace PMS_Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController(ICookieAuthenticationService authenticationService, IUserRepository<Admin> userRepository) : ControllerBase
{

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] AuthenticateAdminRequest request, CancellationToken cancellationToken)
    {
        var response = await authenticationService.AuthenticateAdmin(request, HttpContext, cancellationToken);

        return response ? Ok() : BadRequest();
    }

    [HttpGet("logout")]
    public async Task<IActionResult> LogoutAsync()
    {
        await authenticationService.LogoutAdmin(HttpContext);
        return Ok();
    }

    [Authorize]
    [HttpGet("who-am-i")]
    public async Task<Admin?> WhoAmIAsync(CancellationToken cancellationToken)
    {
        var lol = HttpContext.User.Claims.Where(x => x.ValueType == ClaimValueTypes.Sid);
        return await userRepository.GetByUuid(HttpContext.User.Claims.SingleOrDefault().Value, cancellationToken);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        var users = await userRepository.GetAll(cancellationToken);
        return Ok(users);
    }

}
