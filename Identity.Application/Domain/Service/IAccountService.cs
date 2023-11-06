using Identity.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Domain.Service
{
    public interface IAccountService
    {
        List<User> Users { get; set; }
        ValueTask<bool> VerificationAsync(string token);
      

        Task CreateUserAsync(User user);
    }
}
