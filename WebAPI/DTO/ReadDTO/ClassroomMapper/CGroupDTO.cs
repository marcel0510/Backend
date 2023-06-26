﻿namespace WebAPI.DTO.ReadDTO.ClassroomMapper
{
    public class CGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CSubjectDTO Subject { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
