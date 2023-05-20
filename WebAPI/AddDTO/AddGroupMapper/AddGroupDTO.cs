namespace WebAPI.AddDTO.AddGroupMapper
{
    public class AddGroupDTO
    {
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int ClassroomId { get; set; }
        public List<AddSessionDTO> Sessions { get; set; }
    }
}
