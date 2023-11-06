using DataBase.API.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataBase.API.Persistanse.DataContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();
    }
    
}
