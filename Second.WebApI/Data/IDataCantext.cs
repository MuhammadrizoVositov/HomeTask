using FileBaseContext.Abstractions.Models.FileSet;
using Second.WebApI.Models;

namespace Second.WebApI.Data
{
    public interface IDataCantext:IAsyncDisposable
    {
        IFileSet<User,Guid> Users { get; }
        IFileSet<Order,Guid> Orders { get; }
    }
}
