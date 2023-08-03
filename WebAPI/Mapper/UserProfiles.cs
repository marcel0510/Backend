using AutoMapper;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.ReadDTO;

namespace WebAPI.Mapper
{
    public class UserProfiles : Profile
    {
        public UserProfiles() {

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<AddUserDTO, User>();

        }
    }
}
