using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Index(nameof(Code), IsUnique = true)]  
    public class Building
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; } 
        public List<Classroom> Classrooms { get; set; } 
    }
}
