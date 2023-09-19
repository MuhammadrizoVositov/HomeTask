using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_HT1
{
    public class IUserServise : UserServise
    {
        private List<User> _users = new List<User>();
        public void Add(User user)
        {
            _users.Add(user);   
        }

        public void Delete(int id)
        {
            _users.Remove(GetId(id));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetId(int id)
        {
            return _users.FirstOrDefault(u => u.id == id);
        }

        public void Update(User user)
        {
            var updated=_users.FirstOrDefault(y=>y.FirstName==user.FirstName);
        }
    }
}
