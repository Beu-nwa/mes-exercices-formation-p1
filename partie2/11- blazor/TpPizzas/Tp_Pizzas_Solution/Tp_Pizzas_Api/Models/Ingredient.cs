using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tp_Pizzas_Api.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public ToppingTypes Type { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public decimal Cost { get; set; }
        //[Required]
        public virtual ICollection<PizzaIngredient>? Pizzas { get; set; }

        public enum ToppingTypes
        {
            Dough,
            Sauce,
            Meat,
            Cheese,
            Vegetable,
            Fruit,
            Other
        }
    }
}

