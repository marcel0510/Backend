using AutoMapper;
using Model.Entities;
using System.Globalization;
using WebAPI.AddDTO;
using WebAPI.AddDTO.AddGroupMapper;
using WebAPI.DTO;
using WebAPI.DTO.ClassroomMapper;
using WebAPI.DTO.GroupMapper;
using WebAPI.DTO.SubjectMapper;
using WebAPI.EditDTO;

namespace WebAPI.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Mapeado para ver datos
            CreateMap<User, UserDTO>();
            CreateMap<Session, SessionDTO>();
            CreateMap<Building, BuildingDTO>();

            CreateMap<Group, SGroupDTO>();
            CreateMap<Group, CGroupDTO>();

            CreateMap<Subject, CSubjectDTO>();
            CreateMap<Subject, GSubjectDTO>();

            CreateMap<Classroom, SClassroomDTO>();
            CreateMap<Classroom, GClassroomDTO>();

            CreateMap<Group, GroupDTO>();
            CreateMap<Subject, SubjectDTO>();
            CreateMap<Classroom, ClassroomDTO>();

            //Mapeado para agregar datos
            CreateMap<UserDTO, User>();
            CreateMap<AddUserDTO, User>();
            CreateMap<BuildingDTO, Building>();
            CreateMap<AddSubjectDTO, Subject>();
            CreateMap<AddClassroomDTO, Classroom>();

            CreateMap<AddSessionDTO, Session>()
                .ForMember(ent => ent.StartTime,
                dto => dto.MapFrom(campo => new TimeSpan(
                        DateTime.ParseExact(campo.StartTime, "HH:mm:ss", CultureInfo.InvariantCulture).Hour,
                        DateTime.ParseExact(campo.StartTime, "HH:mm:ss", CultureInfo.InvariantCulture).Minute,
                        DateTime.ParseExact(campo.StartTime, "HH:mm:ss", CultureInfo.InvariantCulture).Second
                    )))
                .ForMember(ent => ent.EndTime,
                dto => dto.MapFrom(campo => new TimeSpan(
                        DateTime.ParseExact(campo.EndTime, "HH:mm:ss", CultureInfo.InvariantCulture).Hour,
                        DateTime.ParseExact(campo.EndTime, "HH:mm:ss", CultureInfo.InvariantCulture).Minute,
                        DateTime.ParseExact(campo.EndTime, "HH:mm:ss", CultureInfo.InvariantCulture).Second
                    )));


            CreateMap<AddGroupDTO, Group>()
                .ForMember(ent => ent.Subject, dto => dto.MapFrom(campo => new Subject() { Id = campo.SubjectId}))
                .ForMember(ent => ent.Classroom, dto => dto.MapFrom(campo => new Classroom() { Id = campo.ClassroomId}));

            //Edit Map

            CreateMap<EditGroupDTO, Group>();

        }
    }
}
