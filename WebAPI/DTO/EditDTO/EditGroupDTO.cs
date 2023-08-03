
using WebAPI.DTO.AddDTO.AddGroupMapper;

namespace WebAPI.DTO.EditDTO
{
    public class EditGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int ClassroomId { get; set; }
        public int CalendarId { get; set; }
        public List<AddSessionDTO> Sessions { get; set; }
        public int UpdatedBy { get; set; }
    }
}
