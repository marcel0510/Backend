namespace WebAPI.DTO.ReadDTO.BuildingMapper
{
    public class BuildingDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<BClassroomDTO> Classrooms { get; set; }
    }
}
