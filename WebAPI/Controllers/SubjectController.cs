using Microsoft.AspNetCore.Mvc;
using Model;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.SubjectMapper;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGroupService _groupService;


        public SubjectController(ScheduleDbContext context, IMapper mapper, IGroupService groupService)
        {
            _context = context;
            _mapper = mapper;
            _groupService = groupService;
        }

        // GET: api/Courses
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<SubjectDTO>>> GetSubjects()
        {
            if (_context.Subject == null) { return NotFound(); }
            return await _context.Subject
                    .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<SubjectDTO>> GetSubject(int id)
        {
            if (_context.Subject == null) { return NotFound(); }
            return await _context.Subject
                    .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(s => s.Id == id);
        }

        [HttpPost("new")]
        
        public async Task<ActionResult> AddSubject(AddSubjectDTO subjectDTO)
        {
            var subjectExists = await _context.Subject.AnyAsync(s => s.Code.ToLower() == subjectDTO.Code.ToLower());
            if (subjectExists) return Ok(new { isSuccess = false, errorType = 1 });
            var subjectDB = _mapper.Map<Subject>(subjectDTO);
            if (subjectDB.Alias == "") subjectDB.Alias = null;
            subjectDB.CreatedDate = DateTime.Now;
            _context.Add(subjectDB);
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateSubject(EditSubjectDTO subjectDTO)
        {
            var subjectExists = await _context.Subject.AnyAsync(s => s.Code.ToLower() == subjectDTO.Code.ToLower());
            if (subjectExists)
            {
                var subjectDB1 = await _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == subjectDTO.Id);
                var isTheSame = subjectDTO.Code == subjectDB1.Code;
                if(isTheSame) {
                    subjectDB1 = _mapper.Map(subjectDTO, subjectDB1);
                    if (subjectDB1.Alias == "") subjectDB1.Alias = null;
                    subjectDB1.UpdatedDate = DateTime.Now;
                    await _context.SaveChangesAsync();
                    return Ok(new { isSuccess = true });
                }
                else
                {
                    return Ok(new { isSuccess = false, errorType = 2 });
                }
            }
            var subjectDB = await _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == subjectDTO.Id);
            subjectDB = _mapper.Map(subjectDTO, subjectDB);
            if (subjectDB.Alias == "") subjectDB.Alias = null;
            subjectDB.UpdatedDate = DateTime.Now;
            return Ok(new { isSuccess = true });
        }

        [HttpDelete("delete/{subjectId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteSubject(int subjectId, int userId)
        {
            var subjectDB = await _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == subjectId);
            if (subjectDB is null) { return Ok(new { isSuccess = false, typeError = 0 }); }
            subjectDB.DeletedBy = userId;
            subjectDB.DeletedDate = DateTime.Now;
            subjectDB.IsDeleted = true;
            var errasedGroups = await _groupService.DeleteGroupsBySubject(_context, subjectId, userId);
            if(!errasedGroups) return Ok(new { isSuccess = false, errorType = 3 });
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

    }
}
