namespace WebAPI.DTO.SubjectMapper
{
    public class SGroupDTO
    {
        public string Name { get; set; }
        public SClassroomDTO Classroom { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
