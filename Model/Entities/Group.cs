using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; } 
        public List<Session> Sessions { get; set; } 
    }
}
