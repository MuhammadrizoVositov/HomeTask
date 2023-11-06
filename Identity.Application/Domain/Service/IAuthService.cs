using Identity.Application.Domain.Identity.Models;

namespace Identity.Application.Domain.Settings;

public interface IAuthService
{
    ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails);
    ValueTask<string>LoginAsync(LoginDetails loginDetails);
}
