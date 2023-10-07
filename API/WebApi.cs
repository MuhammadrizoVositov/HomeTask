using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
        public class WebApiProjectContext 
        {
            public WebApiProjectContext(DbContextOptions<WebApiProjectContext> options)
            {

            }

            public DbSet<User> Users { get; set; }
            public DbSet<Order> Orders { get; set; }

        public class DbSet<T>
        {
        }
    }
    
}
