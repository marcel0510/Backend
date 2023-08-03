using AutoMapper;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.ClassroomMapper;
using WebAPI.DTO.ReadDTO.GroupMapper;

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

            CreateMap<AddClassroomDTO, Classroom>()
                .ForMember(ent => ent.Building, dto => dto.MapFrom(campo => new Building() { Id = campo.BuildingId }));

            CreateMap<EditClassroomDTO, Classroom>()
                .ForMember(ent => ent.Building, dto => dto.MapFrom(campo => new Building() { Id = campo.BuildingId }));

        }
    }
}
