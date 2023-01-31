using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Great_Hangman.Models
{
    public class UserWords
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WordId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(WordId))]
        public Word word { get; set; }
    }
}
