namespace WebAPI.DTO.ReadDTO.ClassroomMapper
{
    public class GeneralClassroomDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsLab { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; }
        public string Period { get; set; }
        public CBuildingDTO Building { get; set; }
    }
}
