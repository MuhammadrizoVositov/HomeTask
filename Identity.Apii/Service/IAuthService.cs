using Identity.Apii.Models;

namespace Identity.Apii.Service
{
    public interface IAuthService
    {
        ValueTask<string> LoginAsync(LoginDetails loginDetails);
        ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails);
    }
}