using System.ComponentModel.DataAnnotations;

namespace WebAPI_securisee.DTOs
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

