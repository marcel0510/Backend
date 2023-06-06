namespace WebAPI.DTO.AddDTO
{
    public class AddSubjectDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int NumHours { get; set; }
        public int NumCredits { get; set; }
        public int NumSemester { get; set; }
        public bool IsLab { get; set; }
    }
}
