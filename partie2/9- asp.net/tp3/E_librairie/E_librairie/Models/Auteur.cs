using System.ComponentModel.DataAnnotations.Schema;

namespace E_librairie.Models
{
    [Table("author")]
    public class Auteur
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Livre> Books { get; set;}
        public Auteur()
        {
            Books= new List<Livre>();
        }
    }
}
