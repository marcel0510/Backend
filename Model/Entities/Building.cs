using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Building: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; } 
        public List<Classroom> Classrooms { get; set; } 
    }
}
