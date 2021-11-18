using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blzr.Shared;
using Microsoft.EntityFrameworkCore;


namespace blzr1.Server.Data
{
    public class BlzrContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
          }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=blzr.db");
        }
    }
}
