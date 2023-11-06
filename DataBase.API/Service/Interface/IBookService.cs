using DataBase.API.Domain.Entites;

namespace DataBase.API.Service.Interface
{
    public interface IBookService
    {
        ValueTask<Book> GetById(Guid id);

        ValueTask<IEnumerable<Book>> GetAsync();

        ValueTask<Book> CreateAsync(Book book);

        ValueTask<Book> UpdateAsync(Book book);

        ValueTask<Book> DeleteAsync(Guid id);
    }
}
