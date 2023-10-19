using N_53_HT1.Models;

namespace N_53_HT1.Events
{
    public class EventServise
    {
        public event Func<User, ValueTask> OrderCreatedEvent;

        public event Func<User, ValueTask> BonusAchievedEvent;

    }
}
