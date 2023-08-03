using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.SubjectMapper;
using Microsoft.AspNetCore.Authorization;
using Model.DAL.Interfaces;

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
        [AllowAnonymous]
        public async Task<ActionResult<SubjectDTO>> GetSubject(int id)
        {
            var Subjects = _subjectDAL.GetAll();
            return await Subjects.ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(s => s.Id == id);
        }

        [HttpPost("new")]
        
        public async Task<ActionResult> AddSubject(AddSubjectDTO subjectDTO)
        {
            var subject = _mapper.Map<Subject>(subjectDTO);
            var request = await _subjectDAL.Add(subject);
            if (request.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = request.ErrorType });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateSubject(EditSubjectDTO subjectDTO)
        {
            var subject = await _subjectDAL.Get(subjectDTO.Id);
            subject = _mapper.Map(subjectDTO, subject);
            var request = await _subjectDAL.Update(subject);
            if (request.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = request.ErrorType });
        }

        [HttpDelete("delete/{subjectId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteSubject(int subjectId, int userId)
        {
            var ok = await _subjectDAL.Delete(subjectId, userId);
            return Ok(new { isSuccess = ok });
        }

    }
}
