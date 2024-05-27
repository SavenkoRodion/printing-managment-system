using PMS_Api.Model.Requests;

namespace PMS_Api.Interfaces;

public interface IAuthService
{
    Task<bool> AuthenticateAdmin(AuthenticateAdminRequest request, HttpContext context, CancellationToken cancellationToken);
    Task LogoutAdmin(HttpContext context);
}
