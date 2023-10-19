




//using System.Reflection.Metadata;






var userA = new List<User>();
{
    new User(1, "Halimjon", "Holiqov");
    new User(2, "Olimjon", "Sodiqov");
    new User(3, "Komiljon", "G'ulamov");
}
var UserB = new List<User>();
{
    new User(4, "Kamol", "Jorabek");
    new User(5, "Jamol", "Jorabek");
    new User(2, "Halimjon", "Jorabek");
}

























public class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public User(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}


//public enum SkillLevel
//{
//    Beginner,
//    Intermediate,
//    Advanced
//}

//public class TalentSkill
//{
//    public int Id { get; set; }

//    public Guid TalentId { get; set; }

//    public string SkillName { get; set; }

//    public SkillLevel SkillLevel { get; set; }

//    public TalentSkill(Guid id, Guid talentId, string skillName, SkillLevel skillLevel)
//    {
//        Id = id;
//        TalentId = talentId;
//        SkillName = skillName;
//        SkillLevel = skillLevel;
//    }
//}