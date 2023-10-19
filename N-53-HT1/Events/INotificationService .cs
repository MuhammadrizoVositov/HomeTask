using N_53_HT1.Models;

namespace N_53_HT1.Events
{
    public interface INotificationService
    {
       
        ValueTask SendEmail(string email, string subject, string message);
        ValueTask SendSms(string phoneNumber, string message);
        ValueTask SendTelegramMessage(string chatId, string message);
    }
}

