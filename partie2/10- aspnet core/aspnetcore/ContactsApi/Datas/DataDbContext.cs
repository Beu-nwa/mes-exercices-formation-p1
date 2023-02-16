using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Datas
{
    public class DataDbContext : DbContext
    {
        //private string _connectionString = @"Data Source=(localdb)\aspnetServeurs;Integrated Security=True";

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
