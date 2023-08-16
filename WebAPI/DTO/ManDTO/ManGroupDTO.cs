namespace WebAPI.DTO.ManDTO
{
    public class ManGroupDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int ClassroomId { get; set; }
        public int CalendarId { get; set; }
        public List<ManSessionDTO> Sessions { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
