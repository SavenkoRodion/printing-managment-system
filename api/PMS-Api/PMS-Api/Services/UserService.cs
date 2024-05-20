using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PMS_Api.Helpers;
using PMS_Api.Interfaces;
using PMS_Api.Model.Requests;
using PMS_Api.Model.Responses;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using User = PMS_Api.Interfaces.User;

namespace PMS_Api.Services;

public class UserService(IOptions<Secret> appSettings, IUserRepository<User> adminRepository)
{
    public async Task<AuthenticateResponse?> Authenticate(AuthenticateRequest request, CancellationToken cancellationToken)
    {
        var user = adminRepository.GetByCredentials(request.Email, request.Password, cancellationToken);

        if (user == null) return null;

        var token = GenerateJwtToken(user);

        return new AuthenticateResponse(user, token);
    }

    public IEnumerable<User> GetAll() { return _users; }

    public User? GetById(int id)
    {
        return _users.FirstOrDefault(x => x.Id == id);
    }

    private string GenerateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(appSettings.Value.Value);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
            Expires = DateTime.UtcNow.AddMinutes(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}
