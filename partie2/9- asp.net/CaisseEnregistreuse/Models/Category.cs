using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnregistreuse.Models
{
    [Table("Category")]
    public class Category
    {
        //public static int Index { get; set; } = 0;
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        public Category() { }
        public Category(int id, string n)
        {
            // CategoryId = IncrementId();
            CategoryId = id;
            Name = n;
        }

        //private static int IncrementId()
        //{
        //    return (int)++Index;
        //}


    }
}
