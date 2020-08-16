using ErdalBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal.DAL
{
    public class ErdalBakkalEntities : DbContext
    {
        public ErdalBakkalEntities() : base("name=ErdalBakkalConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
