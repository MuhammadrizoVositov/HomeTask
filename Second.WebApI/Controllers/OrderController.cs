using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Second.WebApI.Data;
using Second.WebApI.Models;
using Second.WebApI.Repository;

namespace Second.WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrederRepository _orederRepository;

        public OrderController(IOrederRepository orederRepository)
        {
            _orederRepository = orederRepository;
        }

        [HttpGet]
        [Route("\"GetAll\"")]
        public async ValueTask<IEnumerable<Order>> GetAll() =>
            await _orederRepository.GetAll();
        [HttpPost]
        [Route("\"Create\"")]
        public async ValueTask<IActionResult> Create(Order order)
        {
            var ord = await _orederRepository.Create(order);
            return Ok(ord);
        }
        [HttpPatch]
        [Route("\"GetById\"")]
        public async ValueTask<Order> GetById(Guid id)
        {
            return await _orederRepository.GetById(id);
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Order item)
        {
            var a = _orederRepository.Update(item);

            return Ok(a);
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var b = await _orederRepository.Delete(id);

            return Ok(b);
        }
    }
}
