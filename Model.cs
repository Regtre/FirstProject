using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using FirstProject.Models;

namespace FirstProject
{
    public class StoreContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public string DbPath { get; }

        public StoreContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "store.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Store;Trusted_Connection=True");
    }

    
    // For the next step
    // @"Server=localhost;Database=store;User=SA;Password=1Secure*Password1-0322;Trusted_Connection=True;TrustServerCertificate=True;");

}
