using System.ComponentModel.DataAnnotations;

namespace Tp_Pizzas_Api.Models
{
    public class PizzaIngredient
    {
        public int PizzaIngredientId { get; set; }
        [Required]
        public int PizzaId { get; set; }
        [Required]
        public int IngredientId { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
        //public virtual Pizza? Pizza { get; set; }
        //public virtual Ingredient? Ingredient { get; set; }
    }
}
