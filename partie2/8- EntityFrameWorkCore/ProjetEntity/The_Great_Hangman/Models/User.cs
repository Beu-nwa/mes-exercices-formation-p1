using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Great_Hangman.Models
{
    public class User
    {
        public int Id { get; set; }

        [Column("pseudo")]
        [Required]
        [MaxLength(15)]
        public string Pseudo { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
