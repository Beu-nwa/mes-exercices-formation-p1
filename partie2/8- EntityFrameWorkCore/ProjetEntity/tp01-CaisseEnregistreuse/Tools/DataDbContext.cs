using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp01_CaisseEnregistreuse.Models;

namespace tp01_CaisseEnregistreuse.Tools
{
    class DataDbContext : DbContext
    {
        private string connectionString = @"Data Source=(localdb)\bdd;Integrated Security=True";
        public DbSet<Product> Products { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
