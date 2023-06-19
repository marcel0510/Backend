using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Classroom: BaseEntity
    {
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; } 
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public List<Group> Groups { get; set;}

    }
}
