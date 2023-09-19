using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N10Tester
{
    public interface IStudenServise
    {
        Student Create(Student student);
        Student Update(Student student);
        Student Delete(int Id);
        Student GetById(int Id);
        IEnumerable<Student> GetAll();

    }
}

