using Microsoft.EntityFrameworkCore;
using ProjetEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntity.Tools
{
    public class DataDbContext : DbContext
    {
        private string connectionString = @"Data Source=(localdb)\bdd;Integrated Security=True";
        public DbSet<Car> Cars { get; set;  }
        // dans console de gestionnaire de package : 
        // add-migration first
        // update-database
        // crée : dans la bdd la table cars en lui ajoutant un ID unique
        // maintenant on choisi de mofifier les noms de la table, des colonnes etc depuis la classe cars
        // puis : add-migration second
        // update-database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
