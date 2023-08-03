using AutoMapper;
using Model.Entities;
using WebAPI.DTO.AddDTO.AddBuildingMapper;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.BuildingMapper;

namespace WebAPI.Mapper
{
    public class BuildingProfiles : Profile
    {
        public BuildingProfiles() {

            CreateMap<Building, BuildingDTO>();
            CreateMap<Floor, BFloorDTO>();

            CreateMap<AddBuildingDTO, Building>();
            CreateMap<AddFloorDTO, Floor>();

            CreateMap<EditBuildingDTO, Building>();
        }
    }
}
