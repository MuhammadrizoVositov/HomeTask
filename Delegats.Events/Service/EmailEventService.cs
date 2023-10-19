using Delegats.Events.Models;

namespace Delegats.Events.Service
{
    public class EmailEventService
    {
        public event Func<User, ValueTask<string>>? OnEmailCreated;

        public async ValueTask<string> CreateEmail(User user)
        {
            if (OnEmailCreated is not null)
                return await OnEmailCreated(user);
            return $"Sorry, but we can not send any email to the user {user.FirstName} with email {user.Email}";
        }
    }
}
