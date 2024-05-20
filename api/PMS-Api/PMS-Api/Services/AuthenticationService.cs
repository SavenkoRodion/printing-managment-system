using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PMS_Api.Helpers;
using PMS_Api.Interfaces;
using PMS_Api.Model.Db.Scaffold;
using PMS_Api.Model.Requests;
using PMS_Api.Model.Responses;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PMS_Api.Services;

public interface IAuthenticationService
{
    Task<AuthenticateAdminResponse?> AuthenticateAdmin(AuthenticateAdminRequest request, CancellationToken cancellationToken);
}

public class AuthenticationService(IOptions<Secret> appSettings, IUserRepository<Admin> adminRepository) : IAuthenticationService
{
    public async Task<AuthenticateAdminResponse?> AuthenticateAdmin(AuthenticateAdminRequest request, CancellationToken cancellationToken)
    {
        var user = await adminRepository.GetByCredentials(request.Email, request.Password, cancellationToken);

        if (user == null) return null;

        var token = GenerateJwtToken(user);

        return new AuthenticateAdminResponse(user, token);
    }

    private string GenerateJwtToken(Admin user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(appSettings.Value.Value);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", user.Uuid) }),
            Expires = DateTime.UtcNow.AddMinutes(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}
