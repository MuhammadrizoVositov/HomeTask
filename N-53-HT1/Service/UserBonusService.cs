using N_53_HT1.Events;

namespace N_53_HT1.Service
{
    public class UserBonusService
    {
        private readonly OrderCreatedEvent _createdEvent;
        private readonly BonusAchievedEvent _bonusAchievedEvent;
        public UserBonusService(OrderCreatedEvent orderCreatedEvent, BonusAchievedEvent bonusAchievedEvent)
        {
            _createdEvent = orderCreatedEvent;
            _bonusAchievedEvent = bonusAchievedEvent;
        }
        public ValueTask HandleOrederCreated(OrderEventStore orderEventStore) 
        {
            _createdEvent.
        }

    }
}
