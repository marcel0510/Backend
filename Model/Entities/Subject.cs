using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("Subject")]
    [Index(nameof(Code), IsUnique = true)]
    public class Subject: BaseEntity
    {
        [Required]
        [StringLength(8)]
        public string Code { get; set; }
        [Required]
        [StringLength(90)]
        public string Name { get; set; } 
        [Required]
        public int NumHours { get; set; }
        [Required]
        public int NumCredits { get; set; }
        [Required]
        public int NumSemester { get; set; }
        [Required]
        public bool IsLab { get; set; } = false;
        [Required]
        public IEnumerable<Group> Groups { get; set; }
        
    }
}
