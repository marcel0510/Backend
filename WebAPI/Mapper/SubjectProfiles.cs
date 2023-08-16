using AutoMapper;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO;

namespace WebAPI.Mapper
{
    public class SubjectProfiles : Profile
    {
        public SubjectProfiles() {

            CreateMap<Subject, SubjectDTO>();

            CreateMap<ManSubjectDTO, Subject>()
               .ForMember(ent => ent.Id, dto => dto.Condition(campo => campo.Id.HasValue))
               .ForMember(ent => ent.CreatedBy, dto => dto.Condition(campo => campo.CreatedBy.HasValue))
               .ForMember(ent => ent.UpdatedBy, dto => dto.Condition(campo => campo.UpdatedBy.HasValue));


        }
    }
}
