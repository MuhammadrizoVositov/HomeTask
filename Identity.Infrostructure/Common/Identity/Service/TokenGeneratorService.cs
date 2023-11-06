using Identity.Application.Domain.Settings;
using Identity.Application.Settings;
using Identity.Domains.Entities;
using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Infrostructure.Common.Identity.Service
{
    public class TokenGeneratorService : ITokenGeneratorService
    {
        private readonly JwtSettings _jwtSettings;
        //public TokenGeneratorService(IOption<JwtSettings> jwSetting);
        public List<Claim> GetClaims(User user)
        {
            throw new NotImplementedException();
        }

        public JwtSecurityToken GetJwtToken(User user)
        {
            throw new NotImplementedException();
        }

        public string GetToken(User user)
        {
            throw new NotImplementedException();
        }
    }
}
