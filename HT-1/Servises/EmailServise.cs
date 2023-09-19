using HT_1.Models;
using System.Security.Cryptography.X509Certificates;

namespace HT_1.Servises;
public class EmailServise
{
    public IEnumerable<EmailMessage> GetMessages(IEnumerable<EmailTemplete> emailTempletes, IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            foreach(var temp in  emailTempletes)
            {
                yield return new EmailMessage(temp.Subject, temp.Body, "aliexpress@gmail.com", user.Email);
            }

        }
    }
}
