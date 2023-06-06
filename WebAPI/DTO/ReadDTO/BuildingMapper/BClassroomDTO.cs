namespace WebAPI.DTO.ReadDTO.BuildingMapper
{
    public class BClassroomDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; }
    }
}
