using Second.WebApI.Data;
using Second.WebApI.Models;

namespace Second.WebApI.Repository
{
    public class OrderRepository : IOrederRepository 
    {
        private IDataCantext _appDataContext;

        public OrderRepository(IDataCantext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public async ValueTask<IEnumerable<Order>> GetAll()
        {
           return   _appDataContext.Orders.Where(x => !x.IsDeleted);
        }
        public async ValueTask<Order> Create(Order order)
        {
             await _appDataContext.Orders.AddAsync(order);
            await _appDataContext.Orders.SaveChangesAsync();
            return order;
        }

        public ValueTask<Order> GetById(Guid id)
        {
            return new ValueTask<Order>(_appDataContext.Orders.FirstOrDefault(x => x.Id == id));
        }
        public async ValueTask<Order> Update(Order order)
        {
            if(order == null)
                throw new ArgumentNullException(nameof(order));
            var orders= await GetById(order.Id);

            orders.UserId = order.UserId;
            orders.ProductId = order.ProductId;
            orders.OrderedDay = order.OrderedDay;

             await _appDataContext.Orders.SaveChangesAsync();
            return order;
        }
        public async ValueTask<Order> Delete(Guid id)
        {
            var DeleteProduct=_appDataContext.Orders.FirstOrDefault(x => x.Id == id);
            if (DeleteProduct is null) 
                return null;

             DeleteProduct.IsDeleted=true;
            await _appDataContext.Orders.SaveChangesAsync();
            return DeleteProduct;
        }



    }
}
