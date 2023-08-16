
namespace WebAPI.DTO.ManDTO
{
    public class ManBuildingDTO
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<ManFloorDTO> Floors { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
