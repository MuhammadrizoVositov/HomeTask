using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_HT1
{
    public  interface UserServise
    {
        User GetId(int id);
        IEnumerable<User> GetAllUsers();
        void Add(User user);
        void Update(User user);
        void Delete(int id);

    }
}
