using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N_63_HT_1.Models;
using N_63_HT_1.Service;

namespace N_63_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenGeneratorService _tokenGeneratorService;
        public AuthController(TokenGeneratorService tokenGeneratorService)
        {
            _tokenGeneratorService = tokenGeneratorService;
        }

        
        [HttpPost("login")]
        public ValueTask <IActionResult> Login([FromBody]LoginModel loginModel)
        {
            return new(Ok(loginModel));

        }
    }
}
