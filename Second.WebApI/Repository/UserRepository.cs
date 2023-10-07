using Second.WebApI.Data;
using Second.WebApI.Models;

namespace Second.WebApI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataCantext _dataCantext;

        public UserRepository(IDataCantext dataCantext)
        {
            _dataCantext = dataCantext;
        }

        public async ValueTask<IEnumerable<User>> GetAll()
        {
            return _dataCantext.Users.Where(x => !x.isDalete);
        }
        public async ValueTask<User> Create(User user)
        {
            await _dataCantext.Users.AddAsync(user);
            await _dataCantext.Users.SaveChangesAsync();
            return user;
        }
        public ValueTask<User> GetById(Guid id)
        {
            return new ValueTask<User>(_dataCantext.Users.FirstOrDefault(x => x.Id == id));
        }
        public async ValueTask<User> Update(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            var users = await GetById(user.Id);

            user.Name = users.Name;
            user.LastName = users.LastName;
            user.Id = user.Id;
            user.isDalete=true;

            await _dataCantext.Users.SaveChangesAsync();
            return user;
        }
        public async ValueTask<User> Delete(Guid id)
        {
            var Deleted = _dataCantext.Users.FirstOrDefault(x => x.Id == id);
            if (Deleted is null)
                return null;

            Deleted.isDalete = true;
            await _dataCantext.Users.SaveChangesAsync();
            return Deleted;
        }
    }
}
