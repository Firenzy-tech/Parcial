
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial.Controllers.Data.Entities;

namespace Parcial.Controllers.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Id_tikect> Ids { get; set; }
        public DbSet<WasUsed> wasUseds { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Entrance> Entrances { get; set; }
        public DbSet<Date_> Dates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Id_tikect>().HasIndex(s => s.Tikect_number).IsUnique();

            modelBuilder.Entity<WasUsed>().HasIndex(W => W.status).IsUnique();

            modelBuilder.Entity<Document>().HasIndex(d => d.Document_tikect).IsUnique();
            
            modelBuilder.Entity<Name>().HasIndex(n => n.Name_tikect).IsUnique();
            
            modelBuilder.Entity<Entrance>().HasIndex(e => e.entrance).IsUnique();
           
            modelBuilder.Entity<Date_>().HasIndex(f => f.Date).IsUnique();
            
            



        }



    }
}
