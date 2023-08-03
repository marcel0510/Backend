using AutoMapper;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.SubjectMapper;

namespace WebAPI.Mapper
{
    public class SubjectProfiles : Profile
    {
        public SubjectProfiles() {

            CreateMap<Subject, SubjectDTO>();
            CreateMap<Group, SGroupDTO>();
            CreateMap<Classroom, SClassroomDTO>();

            CreateMap<AddSubjectDTO, Subject>();

            CreateMap<EditSubjectDTO, Subject>();

        }
    }
}
