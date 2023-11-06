

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Token.API.Constants;
using Token.API.InterfaceFile;
using Token.API.Model;
using Token.API.Settings;

namespace Token.API.Service

{
    public class TokenGeneratorService:ITokenGeneratorService
    {
        private readonly JwtSettings _jwtSettings;
        public TokenGeneratorService(IOptions<JwtSettings> jwSetting)
        {
            _jwtSettings = jwSetting.Value;
        }
        public string GetToken(User user)
        {
            var jwttoken = GetJwtToken(user);
            var token=new JwtSecurityTokenHandler().WriteToken(jwttoken);
            return token;
        }
        public JwtSecurityToken GetJwtToken(User user)
        {
            var claims=GetClaims(user);
            var securitytoken=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            var credentails= new SigningCredentials(securitytoken,SecurityAlgorithms.HmacSha256);
            return new JwtSecurityToken
                (
                    issuer: _jwtSettings.ValidIssuer,
                    audience: _jwtSettings.ValidAudience,
                    claims: claims,
                    notBefore: DateTime.UtcNow,
                    expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationTimeInMinutes),
                    signingCredentials: credentails
                );
        }

        public List<Claim> GetClaims(User user)
        {
            return new List<Claim>()
            {
                new (ClaimTypes.Email,user.EmailAdress),
                new (ClaimConstants.UserId,user.Id.ToString())
            };
        }


    }
}
