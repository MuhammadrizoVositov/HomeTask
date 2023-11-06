using Identity.Application.Domain.Identity.Models;
using Identity.Application.Domain.Service;
using Identity.Application.Settings;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Azure.Batch.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Infrostructure.Common.Identity.Service
{
    internal class VerificationTokenGeneratorService : IVerificationTokenGeneratorService
    {
        private readonly IDataProtector _dataProtector;
        private readonly VerificationTokenSettings _verificationTokenSettings;
        public VerificationTokenGeneratorService(IOptions<VerificationTokenSettings> verificationTokenSettings, IDataProtectionProvider dataProtectionProvider)
        {
            _verificationTokenSettings = verificationTokenSettings.Value;
            _dataProtector = dataProtectionProvider.CreateProtector(_verificationTokenSettings.IdentityVerificationTokenPurpose);
        }
        public string GenerateToken(VerificationType type, Guid userId)
        {
            var verificationToken = new VerificationToken
            {
                UserId = userId,
                Type = type,
                ExpireTime = DateTimeOffset.UtcNow.AddMinutes(_verificationTokenSettings.IdentityVerificationExpirationDurationInMinutes),
            };
            return _dataProtector.Protect(JsonConvert.SerializeObject(verificationToken));  
        }

        public (VerificationToken Token, bool isValid) DecodeToken(string token)
        {
            if(!string.IsNullOrWhiteSpace(token))
                throw new ArgumentException(nameof(token));
            var unprotectiontoken=_dataProtector.Unprotect(token);
            var verification = JsonConvert.DeserializeObject<VerificationToken>(unprotectiontoken) ??
                throw new ArgumentException("INvalid verification model ", nameof(token));
            return (verification, verification.ExpireTime > DateTimeOffset.UtcNow);
        }

    }
}
