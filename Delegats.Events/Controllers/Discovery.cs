using Delegats.Events.Models;
using Delegats.Events.Service;

namespace Delegats.Events.Controllers
{
    public class Discovery
    {
        private readonly EmailEventService _emailCollection;
        public Discovery(EmailEventService emailCollection)
        {
            _emailCollection = emailCollection;
            _emailCollection.OnEmailCreated += HandEmailCreated;
        }
        public  ValueTask<string> HandEmailCreated(User user)
        {
            return new ValueTask<string>($"Notify {user.FirstName } {user.LastName}");
            
        }

    }

  
}
