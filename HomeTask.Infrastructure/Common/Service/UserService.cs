using HomeTask.Application.Domain;
using HomeTask.Domain.Entities;
using HomeTask.Persistence.DataAcses;

namespace HomeTask.Infrastructure.Common.Service
{
    public class UserService : IUserService
    {
        private readonly AppDataContext _dbContext;

        public UserService(AppDataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async ValueTask<User> Create(User user)
        {
            await _dbContext.AddAsync(user);

            await _dbContext.SaveChangesAsync();

            return user;
        }

        public IQueryable<User> Get()
        {
            return _dbContext.Users;
        }

        public IQueryable<User> Get(IEnumerable<Guid> ids)
        {
            return _dbContext.Users.Where(user => ids.Contains(user.Id));
        }

        public ValueTask<User> GetById(Guid id)
        {
            return new(_dbContext.Users.FirstOrDefault(x => x.Id == id));
        }
    }
}
