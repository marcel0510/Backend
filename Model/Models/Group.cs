using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Group
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int Id { get; set; }
        [Required]
        public Subject Subject { get; set; } = new Subject();
        [Required]
        public IEnumerable<Session> Sessions { get; set;} = Enumerable.Empty<Session>();
    }
}
