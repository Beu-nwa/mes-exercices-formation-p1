using System.ComponentModel.DataAnnotations;

namespace Tp_Pizzas_Api.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "Lastname must start with an Uppercase Letter !")]
        public string Lastname { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "FirstName must start with an Uppercase Letter !")]
        public string Firstname { get; set; }
        [Required]
        public Gender UserGender { get; set; }
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address !")]
        public string Email { get; set; }
        [Required]
        //[RegularExpression(@"^0\d{9}$", ErrorMessage = "Phone number must be like : 0XXXXXXXXX")]
        public string Phone { get; set; }
        public string? Address { get; set; }
        [Required]
        [RegularExpression(@".{8,}$", ErrorMessage = "Invalid password, please make sure it contains at least 8 characteres.")]
        public string PassWord { get; set; }
        [Required]
        public bool IsAdmin { get; set; } = false;

        public enum Gender
        {
            MALE,
            FEMALE,
            OTHER
        }
    }
}
