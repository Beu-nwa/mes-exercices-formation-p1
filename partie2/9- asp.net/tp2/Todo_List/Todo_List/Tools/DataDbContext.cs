using Microsoft.EntityFrameworkCore;

namespace Todo_List.Tools
{
    public class DataDbContext : DbContext
    {
        public DbSet<Task> ToDos { get;set; } 
        private string connectionString = @"Data Source=(localdb)\aspnetServeurs;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
