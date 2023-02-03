namespace E_librairie.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Livre> Books { get; set;}
        public Categorie()
        {
            Books = new List<Livre>();
        }

    }
}
