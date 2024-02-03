using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }  

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db");
            }
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}