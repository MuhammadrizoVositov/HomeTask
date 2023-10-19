using Delegats.Events.Models;
using Delegats.Events.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delegats.Events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<string> Create(User user)
        {
            return await _userService.Create(user);
        }
    }
}
