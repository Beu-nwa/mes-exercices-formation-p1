using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo_List.Models
{
    [Table("todo")]
    public class Task
    {
        public int Id { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("done")]
        public bool Done { get; set; }
    }
}
// add-migration first
//The entity type 'Task' requires a primary key to be defined. If you intended to 
//    use a keyless entity type, call 'HasNoKey' in 'OnModelCreating'. For more 
//    information on keyless entity types, see https://go.microsoft.com/fwlink/?linkid=2141943.