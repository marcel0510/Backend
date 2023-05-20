namespace WebAPI.DTO.GroupMapper
{
    public class GClassroomDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public BuildingDTO Building { get; set; }
    }
}
