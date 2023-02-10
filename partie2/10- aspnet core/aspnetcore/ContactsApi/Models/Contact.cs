using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Linq;

namespace ContactsApi.Models
{
    public class Contact
    {
        //public static int Count;
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        [RegularExpression(@"^[A-Z].*")]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        //public string FullName { get; set; }
        public string FullName => FirstName + " " + LastName;
        //public string FullName { get { return FirstName + " " + LastName; } }
        [Required]
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        [Required]
        public ContactGender Title { get; set; }
        //public string Password { get; set; }
        public string AvatarUrl { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }

        public Contact(string ln, string fn, DateTime bd, ContactGender gd)
        {
            // Id = ++Count;
            LastName = ln;
            FirstName = fn;
            // FullName = fn + " " + ln;
            BirthDate = bd;
            Age = (int)Math.Round((DateTime.Now - bd).TotalDays / 365.25);
            Title = gd;
            AvatarUrl = "";
        }
        public enum ContactGender
        {
            MALE,
            FEMALE,
            OTHER,
        }
    }
}
