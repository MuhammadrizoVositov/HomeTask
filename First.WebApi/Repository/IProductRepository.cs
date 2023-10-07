using First.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace First.WebApi.Repository
{
    public interface IProductRepository
    {
        ValueTask<IEnumerable<Product>> GetAllAsync();
        ValueTask<Product> GetByIdsync(Guid id);
        ValueTask<Product>AddAsync(Product item);
        ValueTask<Product> RemoveAsync(Guid id);
        ValueTask<Product> UpdateAsync(Product item);
    }
}
