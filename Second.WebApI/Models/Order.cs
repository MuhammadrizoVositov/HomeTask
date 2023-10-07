using FileBaseContext.Abstractions.Models.Entity;

namespace Second.WebApI.Models
{
    public class Order:IFileSetEntity<Guid>
    {
        public Guid Id { get ; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime OrderedDay { get; set; }
        public bool IsDeleted { get; set; }
    }
}
