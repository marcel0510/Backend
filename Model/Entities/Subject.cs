using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Subject: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; } 
        public string Alias { get; set; }
        public int NumHours { get; set; }
        public int NumCredits { get; set; }
        public int NumSemester { get; set; }
        public bool IsLab { get; set; }
        public List<Group> Groups { get; set; }
    }
}
