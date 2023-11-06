using DemoApp.Model;
using Mapster;
using System.Security.Cryptography.X509Certificates;

namespace DemoApp.Servic
{
    public class UserService
    {
         private  List<User> _users = new List<User>();
            
        public  User  Create (UserForCreation userForCreation) 
        {
            var exist=_users.FirstOrDefault(x=>x.Email == userForCreation.Email);   
            if (exist != null)
            {
                Console.WriteLine("User Already exist ");
                return exist;
            }
            var users =  userForCreation.Adapt<User>();
            return users;

        }
        public User Get(Guid id) => _users.FirstOrDefault(y=>y.Id==id);
        
            
        
        

        
    
    }
}
