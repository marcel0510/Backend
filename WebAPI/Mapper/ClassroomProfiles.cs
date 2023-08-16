using AutoMapper;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO.ClassroomMapper;

namespace WebAPI.Mapper
{
    public class ClassroomProfiles : Profile
    {
        public ClassroomProfiles() {

            CreateMap<Classroom, ClassroomDTO>();
            CreateMap<Building, CBuildingDTO>();
            CreateMap<Subject, CSubjectDTO>();
            CreateMap<Group, CGroupDTO>();
            CreateMap<Group, CGeneralGroupDTO>().ForMember(dto => dto.Subject, ent => ent.MapFrom(campo => campo.Subject.Name));
            CreateMap<Classroom, GeneralClassroomDTO>();

            CreateMap<ManClassroomDTO, Classroom>()
                .ForMember(ent => ent.Building, dto => dto.MapFrom(campo => new Building() { Id = campo.BuildingId }))
                .ForMember(ent => ent.Id, dto => dto.Condition(campo => campo.Id.HasValue))
                .ForMember(ent => ent.CreatedBy, dto => dto.Condition(campo => campo.CreatedBy.HasValue))
                .ForMember(ent => ent.UpdatedBy, dto => dto.Condition(campo => campo.UpdatedBy.HasValue));


        }
    }
}
