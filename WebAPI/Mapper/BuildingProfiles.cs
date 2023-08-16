using AutoMapper;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO.BuildingMapper;

namespace WebAPI.Mapper
{
    public class BuildingProfiles : Profile
    {
        public BuildingProfiles() {

            CreateMap<Building, BuildingDTO>();
            CreateMap<Floor, BFloorDTO>();
            CreateMap<ManBuildingDTO, Building>()
                .ForMember(ent => ent.Id, dto => dto.Condition(campo => campo.Id.HasValue))
                .ForMember(ent => ent.CreatedBy, dto => dto.Condition(campo => campo.CreatedBy.HasValue))
                .ForMember(ent => ent.UpdatedBy, dto => dto.Condition(campo => campo.UpdatedBy.HasValue));

            CreateMap<ManFloorDTO, Floor>();

        }
    }
}
