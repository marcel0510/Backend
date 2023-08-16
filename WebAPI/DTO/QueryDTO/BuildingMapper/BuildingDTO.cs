
namespace WebAPI.DTO.QueryDTO.BuildingMapper
{
    public class BuildingDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<BFloorDTO> Floors { get; set; }
    }
}
