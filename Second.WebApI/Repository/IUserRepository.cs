using Second.WebApI.Models;

namespace Second.WebApI.Repository
{
    public interface IUserRepository
    {
        ValueTask< IEnumerable<User>> GetAll();
        ValueTask<User> Create(User user);
        ValueTask<User> GetById(Guid id);
        ValueTask< User> Update(User user);
        ValueTask<User> Delete(Guid id);
    }
}
