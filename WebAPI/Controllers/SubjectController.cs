using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Classes;
using Model;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.SubjectMapper;

namespace WebAPI.Controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public SubjectController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectDTO>>> GetSubjects()
        {
            if (_context.Subject == null) { return NotFound(); }
            return await _context.Subject
                    .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SubjectDTO>> GetSubject(int id)
        {
            if (_context.Subject == null) { return NotFound(); }
            return await _context.Subject
                    .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(s => s.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddSubject(AddSubjectDTO subjectDTO)
        {
            var subjectDB = _mapper.Map<Subject>(subjectDTO);
            _context.Add(subjectDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpPut("update/{id:int}")]
        public async Task<ActionResult> UpdateSubject(int id, EditSubjectDTO subjectDTO)
        {
            var subjectDB = await _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == id);
            if (subjectDB is null) { return NotFound(); }
            subjectDB = _mapper.Map(subjectDTO, subjectDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> DeleteSubject(int id)
        {
            var subjetDB = await _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == id);
            if (subjetDB is null) { return NotFound(); }
            subjetDB.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(true);
        }

    }
}
