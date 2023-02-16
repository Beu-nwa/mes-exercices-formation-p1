using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;

namespace PizzaApp.Datas
{
    public class DataDbContext : DbContext
    {
        private string connectionString = @"Data Source=""(localdb)\ blazor_server;Integrated Security=True";
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
