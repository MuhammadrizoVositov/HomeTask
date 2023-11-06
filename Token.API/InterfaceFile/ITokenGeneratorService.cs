using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Token.API.Model;

namespace Token.API.InterfaceFile
{
  
        public interface ITokenGeneratorService
        {
           string GetToken(User user);
            JwtSecurityToken GetJwtToken(User user);
            List<Claim> GetClaims(User user);
        }
    
}

//string GetToken(User user);
//JwtSecurityToken GetJwtToken(User user);
//List<Claim> GetClaims(User user);