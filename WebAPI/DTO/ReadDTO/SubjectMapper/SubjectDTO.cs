namespace WebAPI.DTO.ReadDTO.SubjectMapper
{
    public class SubjectDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int NumHours { get; set; }
        public int NumCredits { get; set; }
        public int NumSemester { get; set; }
        public bool IsLab { get; set; }
        public List<SGroupDTO> Groups { get; set; }
    }
}
