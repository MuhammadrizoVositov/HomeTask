using FileBaseContext.Abstractions.Models.FileSet;
using WebApI.Models;

namespace WebApI.Interface
{
    public interface IDataContext
    {
       IFileSet<User,Guid> Users { get; }
       // IFileSet<Order, Guid> FileSet { get; }
    }
}
