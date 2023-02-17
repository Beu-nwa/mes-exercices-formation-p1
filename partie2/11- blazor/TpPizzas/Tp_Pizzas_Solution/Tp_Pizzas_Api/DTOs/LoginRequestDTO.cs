using System.ComponentModel.DataAnnotations;

namespace Tp_Pizzas_Api.DTOs
{
    public class LoginRequestDTO
    {
        [Required]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        [RegularExpression(@".{8,}$", ErrorMessage = "Invalid password, please make sure it contains at least 8 characteres.")]
        public string? PassWord { get; set; }
    }
}

