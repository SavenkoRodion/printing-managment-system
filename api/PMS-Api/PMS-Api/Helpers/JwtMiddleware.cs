using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PMS_Api.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace PMS_Api.Helpers;

public class JwtMiddleware(RequestDelegate next, IOptions<Secret> appSettings)
{
    public async Task Invoke(HttpContext context, IUserService userService)
    {
        var token = context.Request.Headers.Authorization.FirstOrDefault()?.Split(" ").Last(); //how does it looks like?

        if (token != null)
            AttachUserToContext(context, userService, token);

        await next(context);
    }

    private void AttachUserToContext(HttpContext context, IUserService userService, string token)
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
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value); //refactor the claims?

            context.Items["User"] = userService.GetById(userId); //Refactor?
        }
        catch { } // catch? What could go wrong?
    }
}
