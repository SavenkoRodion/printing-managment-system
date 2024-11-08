using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;

namespace PMS_Api.Controllers
{
    [Authorize]
    [Route("api/auth")]
    [ApiController]
    public class AuthController(IAuthService authService, IUserRepository<Admin> adminRepository) : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> LoginAsync([FromBody] AuthenticateAdminRequest request, CancellationToken cancellationToken)
        {
            var result = await authService.AuthenticateAdmin(request, HttpContext, cancellationToken);

            if (!result) return BadRequest();

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("logout")]
        public async Task<ActionResult> LogoutAsync()
        {
            await authService.LogoutAdmin(HttpContext);

            return Ok();
        }


        [HttpGet("who-am-i")]
        public async Task<Admin?> WhoAmIAsync(CancellationToken cancellationToken)
        {
            return await adminRepository.GetByUuidAsync(HttpContext.User.Claims.Where(x => x.Type == "Uuid").Single().Value, cancellationToken);
        }
    }
}
