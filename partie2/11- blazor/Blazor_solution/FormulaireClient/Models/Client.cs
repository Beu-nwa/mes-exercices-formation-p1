using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FormulaireClient.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required, StringLength(12, MinimumLength = 3, ErrorMessage = "Le nom doit faire entre 3 et 12 caractères")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Le code postal doit être un nombre entier positif.")]
        public int? PostalCode { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "L'Age doit être un nombre entier positif.")]
        public int? Age { get; set; }

        private DateOnly _birthDate = DateOnly.FromDateTime(DateTime.Today);
        [Required(ErrorMessage = "La date de naissance est requise.")]
        public DateOnly BirthDate
        {
            get => _birthDate;
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Today))
                {
                    throw new ArgumentException("La date de naissance ne peut pas être postérieure à la date actuelle.");
                }
                _birthDate = value;
            }
        }
        [Required]
        public bool IsMarried { get; set; } = false;
        [Required]
        public Colors FavoriteColor { get; set; }
        public enum Colors
        {
            Other,
            Red,
            Brown,
            Yellow,
            Orange,
            White
        }
    }
}
