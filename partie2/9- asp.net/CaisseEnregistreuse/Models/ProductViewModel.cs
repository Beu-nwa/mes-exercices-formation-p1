using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnregistreuse.Models
{
    [Table("Product")]
    public class ProductViewModel
    {
        public static int Index { get; set; } = 0;
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int? CategoryId { get; set; }

        public ProductViewModel() { }
        public ProductViewModel(string n, double p)
        {
            ProductId = IncrementId();
            Name = n;
            Price = p;
        }
        public ProductViewModel(string n, double p, int i)
        {
            ProductId = IncrementId();
            Name = n;
            Price = p;
            CategoryId = i;
        }

        private static int IncrementId()
        {
            return (int)++Index;
        }

    }
}
