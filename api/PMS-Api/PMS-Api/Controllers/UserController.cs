using Microsoft.AspNetCore.Mvc;
using PMS_Api.Helpers;
using PMS_Api.Model.Requests;

namespace PMS_Api.Controllers;

[ApiController]
[Route("User")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost("Authenticate")]
    public IActionResult Authenticate([FromBody] AuthenticateRequest model, CancellationToken cancellationToken)
    {
        var response = userService.Authenticate(model);

        if (response == null)
            return BadRequest(new { message = "Username or password is incorrect" });

        return Ok(response);
    }

    [Authorize]
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = userService.GetAll();
        return Ok(users);
    }
}
