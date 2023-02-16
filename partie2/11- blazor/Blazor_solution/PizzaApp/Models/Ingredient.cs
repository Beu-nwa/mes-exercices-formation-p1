using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public Types Type { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public int Cost { get; set; }
        [ForeignKey("pizzaId")]
        public List<Pizza>? Pizzas { get; set; }

        public enum Types
        {
            Dough,
            Sauce,
            Meat,
            Cheese,
            Vegetable,
            Fruit,
            Other
        }
        public bool ToppingStockAvailable(int toTake = 1)
        {
            return Stock - toTake >= 0;
        }
    }
}
