using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Enum;

namespace WebAPI.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }


 

}
