using AutoMapper;
using Model.Entities;
using System.Globalization;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO;
using WebAPI.DTO.QueryDTO.GroupMapper;

namespace WebAPI.Mapper
{
    public class GroupProfiles : Profile
    {
        public GroupProfiles() {

            //Para consulta
            CreateMap<Group, GroupDTO>();
            CreateMap<Subject, GSubjectDTO>();
            CreateMap<Classroom, GClassroomDTO>()
                .ForMember(dto => dto.Building, ent => ent.MapFrom(campo => campo.Building.Code));
            CreateMap<Model.Entities.Calendar, GCalendarDTO>();
            CreateMap<Session, SessionDTO>()
               .ForMember(dto => dto.StartTime, ent => ent.MapFrom(campo => campo.StartTime.ToString(@"hh\:mm")))
               .ForMember(dto => dto.EndTime, ent => ent.MapFrom(campo => campo.EndTime.ToString(@"hh\:mm")));
            CreateMap<Group, GeneralGroupDTO>();

            //Para agregado
            CreateMap<ManGroupDTO, Group>()
               .ForMember(ent => ent.Subject, dto => dto.MapFrom(campo => new Subject() { Id = campo.SubjectId }))
               .ForMember(ent => ent.Classroom, dto => dto.MapFrom(campo => new Classroom() { Id = campo.ClassroomId }))
               .ForMember(ent => ent.Calendar, dto => dto.MapFrom(campo => new Model.Entities.Calendar() { Id = campo.CalendarId }))
               .ForMember(ent => ent.Id, dto => dto.Condition(campo => campo.Id.HasValue))
               .ForMember(ent => ent.CreatedBy, dto => dto.Condition(campo => campo.CreatedBy.HasValue))
               .ForMember(ent => ent.UpdatedBy, dto => dto.Condition(campo => campo.UpdatedBy.HasValue));

            CreateMap<ManSessionDTO, Session>()
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

           
        }
    }
}
