using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Token.API.InterfaceFile;
using Token.API.Model;

namespace Token.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDetails loginDetails)
        {
           return Ok(_authService.LoginAsync(loginDetails));
        }
        [HttpPost("Register")]
        public IActionResult Register(RegistrationDetails registerDetails)
        {
            return Ok(_authService?.RegisterAsync(registerDetails));
        }
        
    }
}
