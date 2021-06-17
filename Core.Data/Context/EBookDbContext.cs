using Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Context
{
    public class EBookDbContext : DbContext
    {
        public DbSet<EBook> EBooks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
