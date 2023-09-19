using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT2
{
    public class Person
    {
        
        
            public record Persons(string FirstName, string LastNmae, int Age);
            public record Employee(string FirstName, string LastNmae, int Age, string EmployeId) : Persons(FirstName, LastNmae, Age);
            public record Manager(string FirstName, string LastNmae, int Age, string EmployeId, int TeamSize) : Employee(FirstName, LastNmae, Age, EmployeId);
        
    }
}

