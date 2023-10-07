using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N45_HT_1
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public User(int id, string firstName)
        {
            Id = id;
            FirstName = firstName;
        }   
    }
}
