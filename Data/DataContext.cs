using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Users> Users { get; set;}
        public DbSet<Characters> Characters { get; set;}
        public DbSet<Weapons> Weapons { get; set;}
        public DbSet<Skills> Skills { get; set;}
    }
}