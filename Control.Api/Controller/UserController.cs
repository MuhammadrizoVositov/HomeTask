using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Control.Api.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UserController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {

        }
        [HttpPost]
        public IActionResult Adduser([FromBody] User user ) 
        {
            
        }

    }
}
