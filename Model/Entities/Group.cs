using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("Group")]
    [Index(nameof(Name), nameof(SubjectId), IsUnique =true)]
    public class Group: BaseEntity
    {
        [Required]
        [StringLength(6)]
        public string Name { get; set; } 
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public Subject Subject { get; set; } 
        [Required]
        public Classroom Classroom { get; set; } 
        [Required] 
        public List<Session> Sessions { get; set; } 


    }
}
