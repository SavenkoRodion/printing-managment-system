using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model;
using System.Security.Claims;

namespace PMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(PmsContext context) : ControllerBase
    {

        [HttpPost("login")]
        public async Task<ActionResult> Login(AuthenticationRequest request)
        {
            var user = context.Admins.FirstOrDefault(x => x.Password == request.Password && x.Email == request.Email);

            if (user == null)
            {
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
