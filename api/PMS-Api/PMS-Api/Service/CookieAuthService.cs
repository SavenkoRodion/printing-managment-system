using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using System.Security.Claims;

namespace PMS_Api.Service;

public class CookieAuthService(IUserRepository<Admin> adminRepository) : IAuthService
{
    public async Task<bool> AuthenticateAdmin(AuthenticateAdminRequest request, HttpContext context, CancellationToken cancellationToken)
    {
        var user = await adminRepository.GetByCredentialsAsync(request.Email, request.Password, cancellationToken);

        if (user == null)
        {
            await context.SignOutAsync();
            return false;
        }

        var claims = new List<Claim> { new("Uuid", user.Uuid.ToString()) };

        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties
        {
            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            IsPersistent = true,
        };

        await context.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            authProperties);

        return true;
    }

    public async Task LogoutAdmin(HttpContext context)
    {
        await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}
