using CaisseEnregistreuseV2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CaisseEnregistreuseV2.Tools
{
    public class DataDbContext : DbContext
    {
        private string connectionString = @"Data Source=(localdb)\bdd;Integrated Security=True";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
