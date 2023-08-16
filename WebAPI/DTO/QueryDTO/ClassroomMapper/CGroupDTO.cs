namespace WebAPI.DTO.QueryDTO.ClassroomMapper
{
    public class CGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CalendarId { get; set; }
        public CSubjectDTO Subject { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
