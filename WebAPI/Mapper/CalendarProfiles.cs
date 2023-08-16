using AutoMapper;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO;

namespace WebAPI.Mapper
{
    public class CalendarProfiles : Profile
    {
        public CalendarProfiles() {

            CreateMap<Calendar, CalendarDTO>()
               .ForMember(dto => dto.PeriodInit, ent => ent.MapFrom(campo => campo.PeriodInit.ToString("yyyy-MM-dd")))
               .ForMember(dto => dto.PeriodEnd, ent => ent.MapFrom(campo => campo.PeriodEnd.ToString("yyyy-MM-dd")));

            CreateMap<ManCalendarDTO, Calendar>()
               .ForMember(ent => ent.PeriodInit, dto => dto.MapFrom(campo => DateTime.Parse(campo.PeriodInit)))
               .ForMember(ent => ent.PeriodEnd, dto => dto.MapFrom(campo => DateTime.Parse(campo.PeriodEnd)))
               .ForMember(ent => ent.Id, dto => dto.Condition(campo => campo.Id.HasValue))
               .ForMember(ent => ent.CreatedBy, dto => dto.Condition(campo => campo.CreatedBy.HasValue))
               .ForMember(ent => ent.UpdatedBy, dto => dto.Condition(campo => campo.UpdatedBy.HasValue));
        }
    }
}
