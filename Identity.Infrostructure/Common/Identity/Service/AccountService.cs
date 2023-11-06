using Identity.Application.Domain.Service;
using Identity.Domains.Entities;

namespace Identity.Infrostructure.Common.Identity.Service
{
    public class AccountService : IAccountService
    {
        public List<User> Users { get ; set ; }

        public Task CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> VerificationAsync(string token)
        {
            throw new NotImplementedException();
        }
    }
}
