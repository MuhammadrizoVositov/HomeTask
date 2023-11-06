using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Verification.API.Models;
using Verification.API.Service;

namespace Verification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly VerificationTokenService _verificationTokenService;

        public UserController(VerificationTokenService verificationTokenService)
        {
             _verificationTokenService = verificationTokenService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(_verificationTokenService.GetToken(user));
        }
        [HttpPost("{token}")]
        public IActionResult Create([FromRoute] string token)
        {
            return Ok(_verificationTokenService.Decode(token));
        }

    }
}
