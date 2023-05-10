using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Model.Enum;

namespace Model.Models
{
    [Table("Session")]
    public class Session: BaseEntity
    {
        [Required]
        public Day Day { get; set; }
        [Required]
        [Column(TypeName = "TIME")]
        public TimeSpan StartTime { get; set; }
        [Required]
        [Column(TypeName = "TIME")]
        public TimeSpan EndTime { get; set; }
        [Required]
        public Group Group { get; set; }
    }
}
