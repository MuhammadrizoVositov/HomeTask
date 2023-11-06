using HomeTask.Application.Domain;
using HomeTask.Persistence.DataAcses;

namespace HomeTask.Infrastructure.Common.Service
{
    public class RoleService : IRoleService
    {
        private readonly AppDataContext _dbContext;

        public RoleService(AppDataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Guid> GetStudents()
        {
            return _dbContext.Roles.ToList()
              .Where(role => role.Name.Contains("stud", StringComparison.OrdinalIgnoreCase))
              .Select(role => role.UserId);
        }

        public IEnumerable<Guid> GetTeachers()
        {
            return _dbContext.Roles.ToList()
                 .Where(role => role.Name.Contains("teach", StringComparison.OrdinalIgnoreCase))
                 .Select(role => role.UserId);
        }
    }
}
