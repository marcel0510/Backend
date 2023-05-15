using AutoMapper;
using Model.Entities;
using WebAPI.DTO.ClassroomMapper;
using WebAPI.DTO.SubjectMapper;

namespace WebAPI.DTO
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Session, SessionDTO>();
            CreateMap<Building, BuildingDTO>();

            CreateMap<Group, SGroupDTO>();
            CreateMap<Group, CGroupDTO>();

            CreateMap<Subject, CSubjectDTO>();
            CreateMap<Classroom, SClassroomDTO>();

            CreateMap<Subject, SubjectDTO>();
            CreateMap<Classroom, ClassroomDTO>();

        }
    }
}
