using WebAPI.AddDTO.AddGroupMapper;

namespace WebAPI.EditDTO
{
    public class EditGroupDTO
    {
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int ClassroomId { get; set; }
        public List<AddSessionDTO> Sessions { get; set; }
    }
}
