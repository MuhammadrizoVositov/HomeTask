using System.Collections;
namespace HT_1_Models;
public class UsersContainer:IEnumerable<User>
{
    private readonly List<User> _users;
    public UsersContainer()
    {
        _users = new List<User>();
    }
    public UsersContainer(List<User> users) 
    {
        _users = users;
    }
    public User this[Guid id]=>_users.Find(us=>us.Id==id);
    public User this[string keyword]=>_users.FirstOrDefault(user=>user.FirstName.Contains(keyword,StringComparison.OrdinalIgnoreCase) 
    && user.LastName.Contains(keyword,StringComparison.OrdinalIgnoreCase)
    && user.EmailAdress.Contains(keyword,StringComparison.OrdinalIgnoreCase));
    public User this[int indexer] => _users[indexer];
    public IEnumerator GetEnumerator()
    {
        return _users.GetEnumerator();
    }

    IEnumerator<User> IEnumerable<User>.GetEnumerator()
    {
        return _users.GetEnumerator();
    }
}
