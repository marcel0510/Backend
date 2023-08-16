using Model.Enum;

namespace WebAPI.DTO.QueryDTO
{
    public class SessionDTO
    {
        public Day Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
