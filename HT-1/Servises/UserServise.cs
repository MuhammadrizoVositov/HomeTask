using HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1.Servises
{
    public class UserServise
    {
        public IEnumerable<User> GetUsers()
        {
            var users = new List<User> ();
            {
                new User { FirstName = "Yoqubjon", LastName = "Holiqov", Status = "Active" };
                new User { FirstName = "Orifjon", LastName = "berdiyev", Status = "Registrated" };
                new User { FirstName = "Dilnoza", LastName = "holmatova", Status = "Deleted" };
                new User { FirstName = "Jamol", LastName = "Komilov", Status = "Active" };
                new User { FirstName = "Hosilbek", LastName = "Nuraliyev", Status = "Deleted" };
            }
            foreach (var user in users) 
            {
                yield return user;
            }
        }
    }
}


//Bu userlarni yield qilib jonatish

 
