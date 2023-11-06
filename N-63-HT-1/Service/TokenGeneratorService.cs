using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;
using N_63_HT_1.Constans;
using N_63_HT_1.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace N_63_HT_1.Service
{
    public class TokenGeneratorService
    {
        public string SecurityKey = "76A56E7B-BE3B-4014-B249-029FD3B25BFF";


        public string GenerateAcsessToken(User user)
        {
            var newtest = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
            var key = new SigningCredentials(newtest, SecurityAlgorithms.HmacSha256);
            var claim = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimsType.UserId, user.UserId.ToString())
            };
            var token = new JwtSecurityToken
                (
                    issuer: "Issuer",
                    audience: "audience",
                    claims: claim,
                    expires: DateTime.Now.AddMinutes(2),
                    signingCredentials: key
                ); 
            return new  JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
