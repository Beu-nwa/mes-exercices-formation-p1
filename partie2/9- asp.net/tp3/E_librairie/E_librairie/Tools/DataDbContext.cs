using E_librairie.Models;
using Microsoft.EntityFrameworkCore;

namespace E_librairie.Tools
{
    public class DataDbContext : DbContext
    {
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }

        private string connectionString = @"Data Source=(localdb)\aspnetServeurs;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
