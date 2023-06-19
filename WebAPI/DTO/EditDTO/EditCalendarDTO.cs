namespace WebAPI.DTO.EditDTO
{
    public class EditCalendarDTO
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public string PeriodInit { get; set; }
        public string PeriodEnd { get; set; }
        public int UpdatedBy { get; set; }
    }
}
