using HomeTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Application.Domain
{
    public interface IUserService
    {
        public IQueryable<User> Get();
        public IQueryable<User> Get(IEnumerable<Guid> ids);
        public ValueTask<User> GetById(Guid id);
        public ValueTask<User> Create(User user);
    }
}
