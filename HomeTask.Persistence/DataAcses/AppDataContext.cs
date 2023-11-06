using HomeTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Persistence.DataAcses;

public class AppDataContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<StudentCourse> Students => Set<StudentCourse>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<UserSettings> UserSettings => Set<UserSettings>();
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
