namespace WebAPI.DTO.AddDTO
{
    public class AddCalendarDTO
    {
        public string Period { get; set; }
        public string PeriodInit { get; set; }
        public string PeriodEnd { get; set; }
        public bool NeedsCopy { get; set; }
        public int CalendarId { get; set; }
        public int CreatedBy { get; set; }
    }
}

