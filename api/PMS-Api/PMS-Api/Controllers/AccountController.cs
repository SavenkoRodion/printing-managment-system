using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model;
using System.Security.Claims;

namespace PMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(VeraprintContext context) : ControllerBase
    {
        private readonly VeraprintContext _context = context;

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            UzytkownicyNowa user = new() { Haslo = "", DataUtworzenia = "", Imie = "", Id = 0, Uid = "" };

            if (user == null || user.Haslo != model.Password)
            {
                return Unauthorized();
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, user.Imie),
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


    public class LoginViewModel
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
