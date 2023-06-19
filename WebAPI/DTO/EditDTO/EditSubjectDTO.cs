﻿namespace WebAPI.DTO.EditDTO
{
    public class EditSubjectDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int NumHours { get; set; }
        public int NumCredits { get; set; }
        public int NumSemester { get; set; }
        public bool IsLab { get; set; }
        public int UpdatedBy { get; set; }
    }
}
