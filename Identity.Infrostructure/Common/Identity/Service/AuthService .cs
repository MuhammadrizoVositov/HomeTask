using Identity.Application.Domain.Identity.Models;
using Identity.Application.Domain.Service;
using Identity.Application.Domain.Settings;
using Identity.Application.Notification;
using Identity.Domains.Entities;
using System.Security.Authentication;

namespace Identity.Infrostructure.Common.Identity.Service
{
    public class AuthService : IAuthService
    {
        private readonly ITokenGeneratorService _tokenGeneratorService;
        private readonly IPasswordHasherService _passwordHasherService;
        private readonly IAccountService _accountService;
        private readonly IEmailOrchestrationService _emailOrchestrationService;
        public AuthService
            (
            ITokenGeneratorService tokenGeneratorService,
            IPasswordHasherService passwordHasherService,
            IAccountService accountService,
            IEmailOrchestrationService emailOrchestrationService
            )
        {
            _tokenGeneratorService = tokenGeneratorService;
            _passwordHasherService = passwordHasherService;
            _accountService = accountService;
            _emailOrchestrationService = emailOrchestrationService;
        }


        public async ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails)
        {
            var founduser = _accountService.Users.FirstOrDefault(user => user.EmailAddress == registrationDetails.EmailAddress);
            if(founduser is null)
            {
                throw new  InvalidOperationException("Alredy excist this acoount");
            }
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = registrationDetails.FirstName,
                LastName = registrationDetails.LastName,
                Age = registrationDetails.Age,
                EmailAddress = registrationDetails.EmailAddress,
                PasswordHash = _passwordHasherService.HashPassword(registrationDetails.Password)
            };
            await _accountService.CreateUserAsync(user);
            var verificationEmailResult = await _emailOrchestrationService.SendAsync(registrationDetails.EmailAddress,"Sistemaga hush kelibsz");
            return verificationEmailResult;
        }
        public ValueTask<string> LoginAsync(LoginDetails loginDetails)
        {
            var founduser = _accountService.Users.FirstOrDefault(user => user.EmailAddress == loginDetails.EmailAdress);
            if (founduser is null && !_passwordHasherService.ValidatePassword(loginDetails.Password, founduser.PasswordHash))
                throw new AuthenticationException("LoginDetails are invalid ");
            var accsestoken = _tokenGeneratorService.GetToken(founduser);
            return new(accsestoken);
        } 
    }
}
