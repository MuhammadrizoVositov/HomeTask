using Microsoft.Azure.Batch.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Domain.Identity.Models
{
    public  class VerificationToken
    {
        public Guid UserId { get; set; }
        public VerificationType Type { get; set; }
        public DateTimeOffset ExpireTime { get; set; }
    }
}
