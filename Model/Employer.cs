using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Employer
    {
        public record Employe(string Name, string Department, decimal Salary);
    }
}
