﻿namespace WebAPI.DTO.ManDTO
{
    public class ManCalendarDTO
    {
        public int? Id { get; set; }
        public string Period { get; set; }
        public string PeriodInit { get; set; }
        public string PeriodEnd { get; set; }
        public bool NeedsCopy { get; set; }
        public int CalendarId { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
