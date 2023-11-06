using Identity.Domains.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Identity.Application.Domain.Settings
{
    public interface ITokenGeneratorService
    {
        string GetToken(User user);
        JwtSecurityToken GetJwtToken(User user);
        List<Claim> GetClaims(User user);
    }
}
