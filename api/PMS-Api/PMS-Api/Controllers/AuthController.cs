using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.Scaffold;
using System.Security.Claims;

namespace PMS_Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController(IUserRepository<Admin> adminRepository) : ControllerBase
    {

        [HttpPost("login")]
        public async Task<ActionResult> Login(AuthenticationRequest request, CancellationToken cancellationToken)
        {
            var user = await adminRepository.GetByCredentials(request.Email, request.Password, cancellationToken);

            if (user == null)
            {
                await HttpContext.SignOutAsync();
                return Unauthorized();
            }

            var claims = new List<Claim>
            {
                new("Uuid", user.Uuid),
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return Ok();
        }
    }


    public record AuthenticationRequest(string Email, string Password);
}
