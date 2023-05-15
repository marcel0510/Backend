namespace WebAPI.DTO.ClassroomMapper
{
    public class CGroupDTO
    {
        public string Name { get; set; }
        public CSubjectDTO Subject { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
