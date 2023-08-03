using AutoMapper;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO;

namespace WebAPI.Mapper
{
    public class CalendarProfiles : Profile
    {
        public CalendarProfiles() {
            CreateMap<Calendar, CalendarDTO>()
               .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => campo.PeriodInit.ToString("yyyy-MM-dd")))
               .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => campo.PeriodEnd.ToString("yyyy-MM-dd")));

            CreateMap<AddCalendarDTO, Calendar>()
               .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodInit)))
               .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodEnd)));

            CreateMap<EditCalendarDTO, Calendar>()
                .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodInit)))
                .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => DateTime.Parse(campo.PeriodEnd)));
        }
    }
}
