using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.DTO.AddDTO.AddBuildingMapper
{
    public class AddBuildingDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<AddFloorDTO> Floors { get; set; }
        public int CreatedBy { get; set; }
    }
}
