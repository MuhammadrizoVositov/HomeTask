using HomeTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Application.Domain
{
    public interface IStudentCourseService
    {
        ValueTask<IEnumerable<User>> GetCourseStudentsById(Guid courseId);
        ValueTask<IEnumerable<Course>> GetStudentCoursesById(Guid strudentId);

        ValueTask<StudentCourse> Create(StudentCourse studentCourse);
    }
}
