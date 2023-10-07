using Second.WebApI.Models;

namespace Second.WebApI.Repository
{
    public interface IOrederRepository
    {
       ValueTask< Order> Create(Order order);
        ValueTask<Order> Update(Order order);
        ValueTask<Order> Delete(Guid id);
        ValueTask<IEnumerable<Order>> GetAll();
        ValueTask<Order> GetById(Guid id);
        
    }
}
