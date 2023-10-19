using N_53_HT1.Events;
using N_53_HT1.Models;

namespace N_53_HT1.Service
{
    public class EmailSenderService : INotificationService
    {
        public ValueTask SendEmail(string email, User user, string message)
        {
     
        }

      

        public ValueTask SendSms(string phoneNumber, string message)
        {
            throw new NotImplementedException();
        }

        public ValueTask SendTelegramMessage(string chatId, string message)
        {
            throw new NotImplementedException();
        }
    }
}
