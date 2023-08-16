namespace WebAPI.DTO.QueryDTO.GroupMapper
{
    public class GeneralGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GSubjectDTO Subject { get; set; }
        public GClassroomDTO Classroom { get; set; }
        public GCalendarDTO Calendar { get; set; }
    }
}
