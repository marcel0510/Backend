using WebAPI.DTO.QueryDTO;

namespace WebAPI.DTO.QueryDTO.GroupMapper
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GSubjectDTO Subject { get; set; }
        public GClassroomDTO Classroom { get; set; }
        public GCalendarDTO Calendar { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
