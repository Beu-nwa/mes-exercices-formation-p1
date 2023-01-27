using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_CaisseEnregistreuse.Models
{
    [Table("Produits")]
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private int stock;
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nom")]
        public string Name { get => name; set => name = value; }
        [Column("description")]
        public string Description { get => description; set => description = value; }
        [Column("stock")]
        public int Stock { get => stock; set => stock = value; }
    }

}
