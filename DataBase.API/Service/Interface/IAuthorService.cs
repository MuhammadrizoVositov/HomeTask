using DataBase.API.Domain.Entites;

namespace DataBase.API.Service.Interface
{
    public interface IAuthorService
    {
        ValueTask<Author> GetById(Guid id);

        ValueTask<IEnumerable<Author>> GetAsync();

        ValueTask<Author> CreateAsync(Author author);

        ValueTask<Author> UpdateAsync(Author author);

        ValueTask<Author> DeleteAsync(Guid id);
    }
}
