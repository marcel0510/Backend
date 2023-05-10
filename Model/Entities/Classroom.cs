using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("Classroom")]
    [Index(nameof(Code), nameof(Floor), IsUnique = true)]
    public class Classroom: BaseEntity
    {

        [Required]
        [StringLength(4)]
        public string Code { get; set; }
        [Required]
        public bool IsLab { get; set; }
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        [StringLength(3)]
        public string Floor { get; set; } 
        [Required]
        public Building Building { get; set; }
        [Required]
        public List<Group> Groups { get; set;}
    }
}
