namespace HomeTask.ApI.Service
{
    public class UserService
    {
        private List<User> _users = new List<User>();
        public UserService() 
        {
            _users.Add(new User { Id = 44, Name = "Holiq:"});
            _users.Add(new User { Id = 44, Name = "Boyliq:" });
            _users.Add(new User { Id = 44, Name = "Ortiq:" });
            _users.Add(new User { Id = 44, Name = "Soliq:" });
        }
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
