namespace Model.Entities
{
    public class Group: BaseEntity
    {
        public string Name { get; set; } 
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public int CalendarId { get; set; }
        public Calendar Calendar { get; set; }
        public List<Session> Sessions { get; set; } 
    }
}
