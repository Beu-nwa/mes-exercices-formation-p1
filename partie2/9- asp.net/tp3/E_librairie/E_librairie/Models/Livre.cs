using System.ComponentModel.DataAnnotations.Schema;

namespace E_librairie.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }


        [Column("author_id")]
        public int? AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Auteur? Author { get; set; }



        [Column("category_id")]
        public int? CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Categorie? Category { get; set; }
    }
}
