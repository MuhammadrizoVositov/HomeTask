using HT_1.Models;
namespace HT_1.Servises;
public class EmailTemplateService
{
    public IEnumerable<EmailTemplete> GetTemplates(IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            if (user.Status == "Active")
            {
                yield return new EmailTemplete()
                {
                    Subject = "Salom  Xush kelibsz",
                    Body = $"Salom{user.FirstName}! Bizning hizmatimizga hush kelibsz ! "

                };

            }
            else if (user.Status == "Registrated")
            {
                yield return new EmailTemplete()
                {
                    Subject = "Royhattan otish: ",
                    Body = $"Salom{user.FirstName} Siz royhattan muofaqiyatli ottingiz: "
                };
            }
        }
    }
}
