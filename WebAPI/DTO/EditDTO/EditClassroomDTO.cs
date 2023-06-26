namespace WebAPI.DTO.EditDTO
{
    public class EditClassroomDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; }
        public int BuildingId { get; set; }
        public int UpdatedBy { get; set; }

    }
}
