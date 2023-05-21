namespace WebAPI.EditDTO
{
    public class EditSubjectDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int NumHours { get; set; }
        public int NumCredits { get; set; }
        public int NumSemester { get; set; }
        public bool IsLab { get; set; }
    }
}
