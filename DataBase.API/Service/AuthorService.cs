using DataBase.API.Domain.Entites;
using DataBase.API.Persistanse.DataContext;
using DataBase.API.Service.Interface;

namespace DataBase.API.Service
{
    public class AuthorService:IAuthorService
    {
        private readonly AppDbContext _context;
        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public async ValueTask<Author> CreateAsync(Author author)

        {
            if(_context.Authors.Any(auth=>auth.Id==author.Id))
            {
                throw new ArgumentException("Author alredy excist");
            }
            _context.Authors.AddRange(author);
            await _context.SaveChangesAsync();
            return author;
        }

        public async ValueTask<Author> DeleteAsync(Guid id)
        {
            var deleteAuthor=await GetById(id);
            
            deleteAuthor.IsDeleted=true;
            return deleteAuthor;
        }

        public ValueTask<IEnumerable<Author>> GetAsync()
        {
           return  new ValueTask<IEnumerable<Author>>(_context.Authors); 
        }

        public ValueTask<Author> GetById(Guid id)
        {
            var author=_context.Authors.FirstOrDefault(x=>x.Id==id);
            if(author is null)
            {
                throw new ArgumentOutOfRangeException("Author not found");
            }
            return new ValueTask<Author>(author);
        }

        public async ValueTask<Author> UpdateAsync(Author author)
        {
            var updateAuthor=await GetById(author.Id);
            updateAuthor.FirstName=author.FirstName;
            updateAuthor.LastName=author.LastName;
            return updateAuthor;
        }
    }
}
