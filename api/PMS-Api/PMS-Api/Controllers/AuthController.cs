using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.Entities;
using PMS_Api.Model.Requests;

namespace PMS_Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController(IAuthService authService, IUserRepository<Admin> adminRepository) : ControllerBase
    {

        [HttpPost("login")]
        public async Task<ActionResult> LoginAsync([FromBody] AuthenticateAdminRequest request, CancellationToken cancellationToken)
        {
            var result = await authService.AuthenticateAdmin(request, HttpContext, cancellationToken);

            if (!result) return BadRequest();

            return Ok();
        }

        [HttpPost("logout")]
        public async Task<ActionResult> LogoutAsync()
        {
            await authService.LogoutAdmin(HttpContext);

            return Ok();
        }

        [Authorize]
        [HttpGet("who-am-i")]
        public async Task<Admin?> WhoAmIAsync(CancellationToken cancellationToken)
        {
            return await adminRepository.GetByUuid(HttpContext.User.Claims.Where(x => x.Type == "Uuid").Single().Value, cancellationToken);
        }
    }
}
