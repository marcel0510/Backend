using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using WebAPI.DTO.QueryDTO;
using Microsoft.AspNetCore.Authorization;
using Model.DAL.Interfaces;
using WebAPI.DTO.ManDTO;

namespace WebAPI.Controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectDAL _subjectDAL;
        private readonly IMapper _mapper;
        public SubjectController(ISubjectDAL subjectDAL, IMapper mapper)
        {
            _subjectDAL = subjectDAL;
            _mapper = mapper;
        }

        // GET: api/Courses
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<SubjectDTO>>> GetSubjects()
        {
            var Subjects = _subjectDAL.GetAll();
            return await Subjects.ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SubjectDTO>> GetSubject(int id)
        {
            var Subjects = _subjectDAL.GetAll();
            return await Subjects.ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(s => s.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddSubject(ManSubjectDTO subjectDTO)
        {
            var subject = _mapper.Map<Subject>(subjectDTO);
            var response = await _subjectDAL.Add(subject);
            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateSubject(ManSubjectDTO subjectDTO)
        {
            var subject = await _subjectDAL.GetForUpdate((int)subjectDTO.Id);
            subject = _mapper.Map(subjectDTO, subject);
            var response = await _subjectDAL.Update(subject);
            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }

        [HttpDelete("delete/{subjectId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteSubject(int subjectId, int userId)
        {
            var ok = await _subjectDAL.Delete(subjectId, userId);
            return Ok(new { isSuccess = ok });
        }

    }
}
