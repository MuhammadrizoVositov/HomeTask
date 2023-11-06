using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Identity.Apii.Service
{
    public class JwtSecurityToken
    {
        private object issuer;
        private object audience;
        private List<Claim> claims;
        private DateTime notBefore;
        private DateTime expires;
        private SigningCredentials signingCredentials;

        public JwtSecurityToken(object issuer, object audience, List<Claim> claims, DateTime notBefore, DateTime expires, SigningCredentials signingCredentials)
        {
            this.issuer = issuer;
            this.audience = audience;
            this.claims = claims;
            this.notBefore = notBefore;
            this.expires = expires;
            this.signingCredentials = signingCredentials;
        }
    }
}