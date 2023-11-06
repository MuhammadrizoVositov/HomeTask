using DemoApp.Model;
using DemoApp.Servic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        [HttpGet]
        public User Get(Guid Id)
        {
            return _userService.Get(Id);
        }
        [HttpPost]
        public User Post(UserForCreation userForCreation)
        {
            return _userService.Create(userForCreation);
        }
       
    }
}
