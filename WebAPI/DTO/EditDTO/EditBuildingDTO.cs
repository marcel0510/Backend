using WebAPI.DTO.AddDTO.AddBuildingMapper;

namespace WebAPI.DTO.EditDTO
{
    public class EditBuildingDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<AddFloorDTO> Floors { get; set; }

        public int UpdatedBy { get; set; }
    }
}
