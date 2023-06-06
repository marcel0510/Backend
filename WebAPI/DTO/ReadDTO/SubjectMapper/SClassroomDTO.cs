using WebAPI.DTO.ReadDTO.BuildingMapper;

namespace WebAPI.DTO.ReadDTO.SubjectMapper
{
    public class SClassroomDTO
    {
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public BuildingDTO Building { get; set; }

    }
}
