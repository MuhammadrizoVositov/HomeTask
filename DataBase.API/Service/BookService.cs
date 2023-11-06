using DataBase.API.Domain.Entites;
using DataBase.API.Persistanse.DataContext;
using DataBase.API.Service.Interface;

namespace DataBase.API.Service
{
    public class BookService : IBookService
    {
       private readonly AppDbContext _appDbContext;
        public BookService(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public async ValueTask<Book> CreateAsync(Book book)
        {
            if(_appDbContext.Books.Any(bok=>bok.Id==bok.Id))
            {
                throw new ArgumentNullException("Book alredy exist");
            }
            _appDbContext.Books.AddRange(book);
            await _appDbContext.SaveChangesAsync();
            return book;

        }

        public async ValueTask<Book> DeleteAsync(Guid id)
        {
            var deletebook= await GetById(id);
            deletebook.IsDeleted = true;
            return deletebook;
        }

        public ValueTask<IEnumerable<Book>> GetAsync()
        {
           return new ValueTask<IEnumerable<Book>>(_appDbContext.Books); 
            
        }

        public ValueTask<Book> GetById(Guid id)
        {
            var book = _appDbContext.Books.FirstOrDefault(bok=>bok.Id==id);
            if(book is null)
            {
                throw new ArgumentOutOfRangeException("Book is not found");
            }
            return new  ValueTask<Book>(book);
        }

        public async ValueTask<Book> UpdateAsync(Book book)
        {
            var updatebook= await GetById(book.Id);

            updatebook.Author = book.Author;
            updatebook.Title = book.Title;
            updatebook.Description = book.Description;
            updatebook.AuthorId = book.AuthorId;
                   
            return updatebook;
        }
    }
}
