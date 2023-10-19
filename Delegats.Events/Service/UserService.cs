using Delegats.Events.Controllers;
using Delegats.Events.Models;

namespace Delegats.Events.Service
{
    public class UserService
    {
        private readonly EmailEventService _emailCollection;
        public UserService(EmailEventService emailCollection)
        {
            _emailCollection = emailCollection;
        }   
        public async ValueTask<string> Create(User user)
        {
             return await _emailCollection.CreateEmail(user);
        }
    }
}
