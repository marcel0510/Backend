namespace WebAPI.DTO.GroupMapper
{
    public class GroupDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public GSubjectDTO Subject { get; set; }
        public GClassroomDTO Classroom { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
