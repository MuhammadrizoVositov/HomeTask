using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Set.Models.FileSet;

namespace Second.WebApI.Models
{
    public interface IEntity:IFileSetEntity<Guid>
    {
        Guid Id { get; set; }
    }
}
