namespace WebAPI.DTO.QueryDTO.ClassroomMapper
{
    public class GeneralClassroomDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; }
        public CBuildingDTO Building { get; set; }
        public List<CGeneralGroupDTO> Groups { get; set; }
    }
}
