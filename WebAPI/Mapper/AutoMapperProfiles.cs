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


            //Mapeo Building
            CreateMap<Building, BuildingDTO>();
            CreateMap<Classroom, BClassroomDTO>();

            //Mapeo Calendar
            CreateMap<Model.Entities.Calendar, CalendarDTO>()
                .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => campo.PeriodInit.ToString("yyyy-MM-dd")))
                .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => campo.PeriodEnd.ToString("yyyy-MM-dd")));

            //Mapeo Classroom
            CreateMap<Classroom, ClassroomDTO>();
            CreateMap<Classroom, GeneralClassroomDTO>();
            CreateMap<Building, CBuildingDTO>();
            CreateMap<Subject, CSubjectDTO>();
            CreateMap<Group, CGroupDTO>();

            //Mapeo para Group
            CreateMap<Group, GroupDTO>();
            CreateMap<Subject, GSubjectDTO>();
            CreateMap<Classroom, GClassroomDTO>()
                .ForMember(dto => dto.Building, ent => ent.MapFrom(campo => campo.Building.Code));
            CreateMap<Model.Entities.Calendar, GCalendarDTO>();

            //Mapeo para Subject
            CreateMap<Subject, SubjectDTO>();
            CreateMap<Group, SGroupDTO>();
            CreateMap<Classroom, SClassroomDTO>();


            //Mapeado para agregar datos
            //Para edificios
            CreateMap<AddBuildingDTO, Building>();
            //Para usuarios
            CreateMap<AddUserDTO, User>();
            //Para materias
            CreateMap<AddSubjectDTO, Subject>();
            //Para Aulas
            CreateMap<AddClassroomDTO, Classroom>()
                .ForMember(ent => ent.Building, dto => dto.MapFrom(campo => new Building() { Id = campo.BuildingId }));

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
