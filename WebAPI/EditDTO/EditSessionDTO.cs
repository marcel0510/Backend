using Model.Enum;

namespace WebAPI.EditDTO
{
    public class EditSessionDTO
    {
        public int Id { get; set; }
        public Day Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
