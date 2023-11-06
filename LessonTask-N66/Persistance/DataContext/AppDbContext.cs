using LessonTask_N66.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask_N66.Persistance.DataContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Books>Book=>Set<Books>();
        public DbSet<Authors> Authors =>Set<Authors>();

        //public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyFirstEfCoreApp;Username=postgres;Password=postgres");
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Books>().HasOne(book => book.Authors).WithMany();
        //}
    }
}
