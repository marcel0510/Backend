using AutoMapper;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO;

namespace WebAPI.Mapper
{
    public class UserProfiles : Profile
    {
        public UserProfiles() {

            CreateMap<User, UserDTO>();
            CreateMap<ManUserDTO, User>();

        }
    }
}
