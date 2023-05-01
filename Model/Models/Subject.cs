using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Subject
    {
        [Key, Required, StringLength(8)]
        public string Code { get; set; } = string.Empty;
        [Required, StringLength(90)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int NumHours { get; set; }
        [Required]
        public int NumCredits { get; set; }
        [Required]
        public int NumSemester { get; set; }
        [Required]
        public bool isLab { get; set; }
        
    }
}
