namespace WebAPI.DTO.ManDTO
{
    public class ManPasswordDTO
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public bool IsRestore { get; set; }
    }
}
