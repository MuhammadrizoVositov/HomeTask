using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N43_HT_1
{
    public class UserServise
    {
       
        private readonly List<User> _users = new List<User>();
        
        public User Create(User newUser)
        {
            _users.Add(newUser);
            return newUser;
        }
        
        public  async ValueTask<FileStream>  CreatePerformanceRecordAsync(int id)
        {
            var mutex = new Mutex(false, "Email");
            var user = await GetById(id);
            return await Task.Run(() =>
            {
                mutex.WaitOne();
                var file = File.Create($"{user.FirstName}{user.LastName}.txt");
                file.Close();
                mutex.ReleaseMutex();
                return file;
            });

        }
        public async ValueTask<User?> GetById(int id)
        {
            return await Task.Run(()=>_users.FirstOrDefault(user=>user.Id==id));
        }
    }
}
