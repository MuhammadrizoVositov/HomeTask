using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N_65_HT1.Models;
using N_65_HT1.Service;

namespace N_65_HT1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly VerificationTokenService verificationTokenService;

        public UsersController(VerificationTokenService verificationTokenService)
        {
            this.verificationTokenService = verificationTokenService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(verificationTokenService.GetToken(user));
        }
        [HttpPost("{token}")]
        public IActionResult Create([FromRoute] string token)
        {
            return Ok(verificationTokenService.Decode(token));
        }
    }
}
