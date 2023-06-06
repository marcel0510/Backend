namespace WebAPI.DTO.ReadDTO.ClassroomMapper
{
    public class CGroupDTO
    {
        public string Name { get; set; }
        public CSubjectDTO Subject { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
