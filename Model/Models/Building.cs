using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Building
    {
        [Key, Required, StringLength(3)]
        public string Code { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Number { get; set; } = string.Empty;

    }
}
