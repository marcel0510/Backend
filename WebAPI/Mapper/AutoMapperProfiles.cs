    using AutoMapper;
using Model.Entities;
using System.Globalization;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.DeleteDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO;
using WebAPI.DTO.ReadDTO.BuildingMapper;
using WebAPI.DTO.ReadDTO.ClassroomMapper;
using WebAPI.DTO.ReadDTO.GroupMapper;
using WebAPI.DTO.ReadDTO.SubjectMapper;

namespace WebAPI.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Mapeado para ver datos
            CreateMap<User, UserDTO>();
            CreateMap<Session, SessionDTO>()
                .ForMember(dto => dto.StartTime, ent => ent.MapFrom(campo => campo.StartTime.ToString(@"hh\:mm")))
                .ForMember(dto => dto.EndTime, ent => ent.MapFrom(campo => "" + campo.EndTime.ToString(@"hh\:mm")));
            CreateMap<Building, CBuildingDTO>();
            CreateMap<Building, BuildingDTO>();

            CreateMap<Group, SGroupDTO>();
            CreateMap<Group, CGroupDTO>();

            CreateMap<Subject, CSubjectDTO>();
            CreateMap<Subject, GSubjectDTO>();

            CreateMap<Classroom, SClassroomDTO>();
            CreateMap<Classroom, GClassroomDTO>();
            CreateMap<Classroom, BClassroomDTO>();
            CreateMap<Classroom, ClassroomDTO>();

            CreateMap<Group, GroupDTO>();
            CreateMap<Subject, SubjectDTO>();
       

            CreateMap<Model.Entities.Calendar, CalendarDTO>()
                .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => campo.PeriodInit.ToString("yyyy-MM-dd")))
                .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => campo.PeriodEnd.ToString("yyyy-MM-dd")));
            

            //Mapeado para agregar datos

            CreateMap<UserDTO, User>();
            CreateMap<AddBuildingDTO, Building>();
            CreateMap<AddUserDTO, User>();
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
                .ForMember(ent => ent.Subject, dto => dto.MapFrom(campo => new Subject() { Id = campo.SubjectId }))
                .ForMember(ent => ent.Classroom, dto => dto.MapFrom(campo => new Classroom() { Id = campo.ClassroomId }))
                .ForMember(ent => ent.Calendar, dto => dto.MapFrom(campo => new Model.Entities.Calendar() { Id = campo.CalendarId }));

            CreateMap<AddCalendarDTO, Model.Entities.Calendar>()
                .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodInit)))
                .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodEnd)));


            //Edit Map

            CreateMap<EditBuildingDTO, Building>();
            CreateMap<EditGroupDTO, Group>();
            CreateMap<EditSubjectDTO, Subject>();
            CreateMap<EditClassroomDTO, Classroom>();
            CreateMap<CalendarDTO, Model.Entities.Calendar>()
                .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodInit)))
                .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodEnd)));

            CreateMap<EditSessionDTO, Session>()
                .ForMember(ent => ent.StartTime,
                dto => dto.MapFrom(campo => new TimeSpan(
                        DateTime.ParseExact(campo.StartTime, "HH:mm", CultureInfo.InvariantCulture).Hour,
                        DateTime.ParseExact(campo.StartTime, "HH:mm", CultureInfo.InvariantCulture).Minute,
                        DateTime.ParseExact(campo.StartTime, "HH:mm", CultureInfo.InvariantCulture).Second
                    )))
                .ForMember(ent => ent.EndTime,
                dto => dto.MapFrom(campo => new TimeSpan(
                        DateTime.ParseExact(campo.EndTime, "HH:mm", CultureInfo.InvariantCulture).Hour,
                        DateTime.ParseExact(campo.EndTime, "HH:mm", CultureInfo.InvariantCulture).Minute,
                        DateTime.ParseExact(campo.EndTime, "HH:mm", CultureInfo.InvariantCulture).Second
                    )));

            //Delete Map

            CreateMap<DeleteBuildingDTO, Building>();


            //Copy Calendar
            CreateMap<GroupDTO, AddGroupDTO>()
                .ForMember(dto => dto.SubjectId, ent => ent.MapFrom(campo => campo.Subject.Id))
                .ForMember(dto => dto.ClassroomId, ent => ent.MapFrom(campo => campo.Classroom.Id))
                .ForMember(dto => dto.CalendarId, ent => ent.MapFrom(campo => campo.Calendar.Id));
            CreateMap<SessionDTO, AddSessionDTO>()
                .ForMember(ent => ent.StartTime, dto => dto.MapFrom(campo => campo.StartTime + ":00"))
                .ForMember(ent => ent.EndTime, dto => dto.MapFrom(campo => campo.EndTime + ":00"));


        }
    }
}
