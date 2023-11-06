using Identity.Application.Domain.Identity.Models;
using Microsoft.Azure.Batch.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Domain.Service
{
    public interface IVerificationTokenGeneratorService
    {
        string GenerateToken(VerificationType type, Guid userId);
        (VerificationToken Token ,bool isValid) DecodeToken(string token);
    }
}
