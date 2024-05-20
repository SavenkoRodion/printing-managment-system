using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PMS_Api.Interfaces;
using PMS_Api.Model.Db.Scaffold;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace PMS_Api.Helpers;

public class JwtMiddleware(RequestDelegate next, IOptions<Secret> appSettings)
{
    public async Task Invoke(HttpContext context, IUserRepository<Admin> userRepository)
    {
        var token = context.Request.Headers.Authorization.FirstOrDefault()?.Split(" ").Last(); //how does it looks like?

        if (token != null)
            AttachUserToContext(context, token, userRepository);

        await next(context);
    }

    private void AttachUserToContext(HttpContext context, string token, IUserRepository<Admin> userRepository)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(appSettings.Value.Value);
            tokenHandler.ValidateToken(
                token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                },
                out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = jwtToken.Claims.First(x => x.Type == "id").Value; //refactor the claims?

            if (userId == null) return;

            context.Items["User"] = userRepository.GetByUuid(userId!, default); //Refactor?
        }
        catch { } // catch? What could go wrong?
    }
}
