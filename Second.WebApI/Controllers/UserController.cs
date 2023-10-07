using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Second.WebApI.Models;
using Second.WebApI.Repository;

namespace Second.WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        [Route("\"GetAll\"")]
        public async ValueTask<IEnumerable<User>> GetAll() =>
           await _userRepository.GetAll();
        [HttpPost]
        [Route("\"Create\"")]
        public async ValueTask<IActionResult> Create(User user)
        {
            var ord = await _userRepository.Create(user);
            return Ok(ord);
        }
        [HttpPatch]
        [Route("\"GetById\"")]
        public async ValueTask<User> GetById(Guid id)
        {
            return await _userRepository.GetById(id);
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(User item)
        {
            var a = _userRepository.Update(item);

            return Ok(a);
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var b = await _userRepository.Delete(id);

            return Ok(b);
        }

    }
}
