namespace WebAPI.DTO.QueryDTO.ClassroomMapper
{
    public class CSubjectDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int NumSemester { get; set; }
        public bool IsLab { get; set; }
    }
}
