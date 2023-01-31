using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_CaisseEnregistreuse.Models
{
    [Table("categorie")]
    public class Categorie
    {
        [Column("id")]
        public int Id { get; set; }


        [Column("titre")]
        public string Title { get; set; }


        public List<Product> Products { get; set; }
        public Categorie()
        {
            Products = new List<Product>();
        }


        public override string ToString()
        {
            return Title;
        }

    }
}
