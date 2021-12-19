using Blzr.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blzr.Server.Data
{
    public class BlzrDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Metatag>? Metatags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=Blzr.db");
        }
    }
}