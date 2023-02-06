namespace E_librairie.Models
{
    public class Library
    {
        public List<Auteur> Authors { get; set; }
        public List<Categorie> Categories { get; set; }
        public List<Livre> Books { get; set; }
    }
}
