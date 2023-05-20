using Model.Enum;

namespace WebAPI.AddDTO
{
    public class AddUserDTO
    {
        public string Name { get; set;}
        public string Email { get; set;}
        public string Password { get; set; }
        public Role Role { get; set;}
    }
}
