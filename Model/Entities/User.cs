using Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class User
    {
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
