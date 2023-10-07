using FileBaseContext.Abstractions.Models.FileSet;
using First.WebApi.Models;

namespace First.WebApi.DataContext;

public interface IDataContext:IAsyncDisposable
{
    IFileSet<Product, Guid> Products { get; }
}
