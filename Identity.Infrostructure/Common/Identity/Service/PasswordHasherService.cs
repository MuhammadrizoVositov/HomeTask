using Identity.Application.Domain.Settings;
using BC = BCrypt.Net.BCrypt;

namespace Identity.Infrostructure.Common.Identity.Service
{
    public class PasswordHasherService : IPasswordHasherService
    {
        public string HashPassword(string password)
        {
            return BC .HashPassword(password);
        }

        public bool ValidatePassword(string password, string hashedPassword)
        {
            return BC.Verify(password, hashedPassword);
        }
    }
}
