using Microsoft.AspNetCore.DataProtection;
using N_65_HT1.Models;
using Newtonsoft.Json;

namespace N_65_HT1.Service
{
    public class VerificationTokenService
    {
        private readonly IDataProtector _protector;

        public VerificationTokenService(IDataProtectionProvider protector)
        {
            _protector = protector.CreateProtector(nameof(VerificationTokenService));
        }

        public string GetToken(User user)
        {
            var token = _protector.Protect(JsonConvert.SerializeObject(user));
            return token;
        }
        public int GenerateCode() => new Random().Next(1000, 10000);

        public User Decode(string token)
        {
            var decode = _protector.Unprotect(token);

            return JsonConvert.DeserializeObject<User>(decode);
        }
    }
}
