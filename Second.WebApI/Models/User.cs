using FileBaseContext.Abstractions.Models.Entity;

namespace Second.WebApI.Models
{
    public class User:IFileSetEntity<Guid>
    {
        public  Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool isDalete { get; set; }


    }
}
