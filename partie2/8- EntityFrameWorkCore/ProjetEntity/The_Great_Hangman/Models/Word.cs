using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Great_Hangman.Models
{
    public class Word
    {
        public int Id { get; set; }

        [Column("mot")]
        [Required]
        [MaxLength(10)]
        public string mot { get; set; }
    }
}
