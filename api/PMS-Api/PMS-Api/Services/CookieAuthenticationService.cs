using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using PMS_Api.Interfaces;
using PMS_Api.Model.Db.Scaffold;
using PMS_Api.Model.Requests;
using System.Security.Claims;

namespace PMS_Api.Services;

public interface ICookieAuthenticationService
{
    Task<bool> AuthenticateAdmin(AuthenticateAdminRequest request, HttpContext context, CancellationToken cancellationToken);
    Task LogoutAdmin(HttpContext context);
}

public class CookieAuthenticationService(IUserRepository<Admin> adminRepository) : ICookieAuthenticationService
{
    public async Task<bool> AuthenticateAdmin(AuthenticateAdminRequest request, HttpContext context, CancellationToken cancellationToken)
    {
        var user = await adminRepository.GetByCredentials(request.Email, request.Password, cancellationToken);

        if (user == null) return false;

        var claims = new List<Claim>
        {
            new("Uuid", user.Uuid),
            new("Name", user.Name),
            new("Email", user.Email)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        await context.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            new AuthenticationProperties());

        return true;
    }

    public async Task LogoutAdmin(HttpContext context)
    {
        await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}
