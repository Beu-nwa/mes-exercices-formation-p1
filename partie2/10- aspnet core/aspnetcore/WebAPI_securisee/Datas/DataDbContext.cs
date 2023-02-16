using Microsoft.EntityFrameworkCore;
using WebAPI_securisee.Models;

namespace WebAPI_securisee.Datas
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
