using CaisseEnregistreuse.Models;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnregistreuse.Tools
{
    public class DataDbContext : DbContext
    {
        private string _connection = "Data Source=(localdb)\aspnetServeurs;Integrated Security=True";
        
        public DbSet<ProductViewModel> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);
        }
    }
}
