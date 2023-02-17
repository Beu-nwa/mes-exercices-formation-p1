using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tp_Pizzas_Api.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public PizzaTypes Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        //[Required]
        public virtual ICollection<PizzaIngredient>? Ingredients { get; set; }
        [Required]
        public string? ImagePath { get; set; }
        public enum PizzaTypes
        {
            Original,
            Spicy,
            Vege,
            Other
        }
    }
}
