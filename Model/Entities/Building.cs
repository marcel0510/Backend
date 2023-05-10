using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("Building")]
    [Index(nameof(Code), IsUnique = true)]  
    public class Building: BaseEntity
    {
        [Required]
        [MaxLength(3)]
        public string Code { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; } 
        [Required]
        public List<Classroom> Classrooms { get; set; } 
    }
}
