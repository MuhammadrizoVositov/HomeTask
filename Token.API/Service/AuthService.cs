using Token.API.InterfaceFile;
using Token.API.Model;

namespace Token.API.Service
{
    public class AuthService : IAuthService
    {
        private readonly ITokenGeneratorService _tokenGeneratorService;
        
        private static List<User> _users = new List<User>();
        public AuthService(ITokenGeneratorService tokenGeneratorService)
        {
            _tokenGeneratorService = tokenGeneratorService;
        }
        public async ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = registrationDetails.FirstName,
                LastName = registrationDetails.LastName,
                EmailAdress=registrationDetails.EmailAddress,
                Password = registrationDetails.Password,
            };
             _users.Add(newUser);
            return true;
        }

        public async ValueTask<string> LoginAsync(LoginDetails loginDetails)
        {
            var user = _users.FirstOrDefault(item => item.EmailAdress == loginDetails.EmailAdress);

            if (user is null)
            {
                throw new ArgumentNullException("User mavjud emas");
            }

            return _tokenGeneratorService.GetToken(user);
        }

    }
}
