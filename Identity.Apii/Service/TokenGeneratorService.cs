﻿using Identity.Apii.Models;
using Jose;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace Identity.Apii.Service
{
    public class TokenGeneratorService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly object ClaimConstants;
        public string SecretKey = "8E6225FC-6E84-4E50-805F-FB3B5B6138BE";

        public TokenGeneratorService(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public string GetToken(User user)
        {
            var jwtToken = GetJwtToken(user);
            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return token;
        }

        public JwtSecurityToken GetJwtToken(User user)
        {
            var claims = GetClaims(user);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            return new JwtSecurityToken(issuer: _jwtSettings.ValidIssuer,
                                        audience: _jwtSettings.ValidAudience,
                                        claims: claims,
                                        notBefore: DateTime.UtcNow,
                                        expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationTimeInMinutes),
                                        signingCredentials: credentials);
        }

        public List<Claim> GetClaims(User user) => new List<Claim>()
        {
            new(ClaimTypes.Email, user.EmailAddress),
            new(ClaimConstants.UserId, user.Id.ToString())
        };
    }

    internal class JwtSecurityTokenHandler
    {
        public JwtSecurityTokenHandler()
        {
        }

        internal string WriteToken(JwtSecurityToken jwtToken)
        {
            throw new NotImplementedException();
        }
    }
}
