using Model.Entities;

namespace WebAPI.DTO.ClassroomMapper
{
    public class ClassroomDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; }
        public BuildingDTO Building { get; set; }
        public List<CGroupDTO> Groups { get; set; }
    }
}
