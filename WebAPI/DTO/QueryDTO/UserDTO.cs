using Model.Enum;

namespace WebAPI.DTO.QueryDTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public bool Reset { get; set; }
    }




}
