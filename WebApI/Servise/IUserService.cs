﻿using System.Linq.Expressions;
using WebApI.Models;

namespace WebApI.Servise
{
    public interface IUserService
    {
        IQueryable<User> Get(Expression<Func<User, bool>> predicate, CancellationToken cancellationToken = default);

        ValueTask<ICollection<User>> GetAsync(IEnumerable<Guid> ids,CancellationToken cancellationToken=default);

        ValueTask<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<User> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<User> DeleteAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

    }
}