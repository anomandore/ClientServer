using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; //inheritance of DbContext from EntityFramework
using DBSystem.ENTITIES;

namespace DBSystem.DAL
{
    internal class Context : DbContext
    {
        public Context() : base("NWDB") { }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
    internal class ContextFSIS : DbContext
    {
        public ContextFSIS() : base("FSISDB") { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

    }
    internal class ContextStarTED : DbContext
    {
        public ContextStarTED() : base("StarTEDDB") { }

    }
}
