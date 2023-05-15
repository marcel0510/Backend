using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Model.Enum;

namespace Model.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public Day Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
