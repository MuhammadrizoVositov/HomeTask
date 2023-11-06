using HomeTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Application.Domain
{
    public interface ICourseService
    {
        IQueryable<Course> Get();
        IQueryable<Course> Get(IEnumerable<Guid> ids);
        ValueTask<Course> GetByIdAsync(Guid id);
        ValueTask<Course> Create(Course course);
        ValueTask<User> AddStudent(User student, Guid courseId);
        ValueTask<User> AddTeacher(User teacher, Guid courseId);
    }
}
