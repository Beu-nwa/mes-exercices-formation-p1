using System.ComponentModel.DataAnnotations;

namespace WebAPI_securisee.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public status Status { get; set; }
        [Required]
        public List<Ingredient> Ingredients { get; set; }

        public enum status
        {
            ORIGINAL,
            VEGE,
            SPICY,
        }
    }
}
