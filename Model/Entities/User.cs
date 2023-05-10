using Model.Enum;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    [Table("User")]
    public class User: BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(25)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public Role Role { get; set; }
    }
}
