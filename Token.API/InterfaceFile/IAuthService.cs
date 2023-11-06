using Token.API.Model;

namespace Token.API.InterfaceFile
{
    public interface IAuthService
    {
        ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails);
        ValueTask<string> LoginAsync(LoginDetails loginDetails);
    }
}
