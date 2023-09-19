using HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1.Servises
{
    public class EmailSenderService
    {
        //public  EmailMessage GetMassega(EmailTemplete templete, User user)
        //{
        //    var emailMessege = new EmailMessage
        //    (
        //         templete.Subject,
        //         templete.Body,
        //         "Jonibek@gamil.com",
        //        $"{user.FirstName}.{user.LastName} Jonibek@gamil.com");


        //    return emailMessege;
        //}
        public async ValueTask<bool> SendEmailsAsync(IEnumerable<EmailMessage> messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine($"Email Yuborildi:\n Subject {message.Subject}\nTo{message.Body}\nBody{message.ReciverAdress} {message.Body} ");
            }
            return true;
        }
    }
}
