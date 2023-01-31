using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_CaisseEnregistreuse.Models
{
    [Table("commentaire")]
    public class Comment
    {
        [Column("id")]
        public int Id { get; set; }


        [Column("content")]
        public string Content { get; set; }


        [Column("product_id")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }



        public override string ToString()
        {
            return Content ;
        }
    }
}
