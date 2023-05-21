using WebAPI.AddDTO.AddGroupMapper;
using WebAPI.DTO;

namespace WebAPI.EditDTO
{
    public class EditGroupDTO
    {
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int ClassroomId { get; set; }
    }
}
