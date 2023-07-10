    namespace WebAPI.DTO.EditDTO
{
    public class EditPassword
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public bool IsRestore { get; set; } 
        
    }
}
