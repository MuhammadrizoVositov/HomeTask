using First.WebApi.DataContext;
using First.WebApi.Models;
using First.WebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
#pragma warning
        private readonly IProductRepository _productRepository;

        public ProductsController( IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async ValueTask<IEnumerable<Product>> GetAllAsync()=>
            await _productRepository.GetAllAsync();
       

        [HttpGet("{id}")]
        public async ValueTask<Product> GetByIdsync(Guid id)
        {
            return await _productRepository.GetByIdsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> ProductAsync(Product product) 
        {
           
            var user = await _productRepository.AddAsync(product);
            return Ok(user);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Product item) 
        {
            var a = _productRepository.UpdateAsync(item);

            return Ok(a);
            
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id) 
        {
            var b = await _productRepository.RemoveAsync(id);

            return Ok(b);
        }

      
    }


    
}
