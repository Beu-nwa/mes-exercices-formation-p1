using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_CaisseEnregistreuse.Models
{
    [Table("produit")]
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private int stock;
        private decimal price;


        [Column("id")]
        public int Id { get => id; set => id = value; }


        [Column("nom")]
        public string Name { get => name; set => name = value; }


        [Column("description")]
        public string Description { get => description; set => description = value; }


        [Column("stock")]
        public int Stock { get => stock; set => stock = value; }


        [Column("categorie_id")]
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public Categorie? Categorie { get; set; }


        public List<Comment> Comments { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get => price; set => price = value; }

        public Product()
        {
            Comments = new List<Comment>();
        }

        public List<SaleProduct> Sales { get; set; }

    }

}
