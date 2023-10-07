using FileBaseContext.Abstractions.Models.FileSet;
using FileBaseContext.Set.Models.FileSet;
using First.WebApi.DataContext;
using First.WebApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace First.WebApi.Repository
{
#pragma warning disable
    public class ProductRepository : IProductRepository
    {
        private readonly IDataContext _dataContext;

        public ProductRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        ////var test = new FileSet<Product, int>(Directory.GetCurrentDirectory(), null, null);
        //private int next_id = 1;

        public async ValueTask<Product> AddAsync(Product item)
        {
             await _dataContext.Products.AddAsync(item);
            await _dataContext.Products.SaveChangesAsync();
            return item;
        }

        public async ValueTask<Product> GetByIdsync(Guid id)
        {

            return  _dataContext.Products.FirstOrDefault(x => x.Id==id);
           
        }

        public async ValueTask<IEnumerable<Product>> GetAllAsync() => _dataContext.Products.Where(prod=>!prod.IsDeleted);
        public async ValueTask<Product> RemoveAsync(Guid id)
        {
            var deletedProduct = await GetByIdsync(id);

            if (deletedProduct is null)
                return null;

            deletedProduct.IsDeleted=true;

            await _dataContext.Products.SaveChangesAsync();   
            
            return deletedProduct;
        }

        public async ValueTask<Product> UpdateAsync(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            var product = await GetByIdsync(item.Id);

            product.Name = item.Name;
            product.Price = item.Price;

            await _dataContext.Products.SaveChangesAsync();

            return item;
        }
    }
}
