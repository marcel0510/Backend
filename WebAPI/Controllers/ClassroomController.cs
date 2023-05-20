using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.AddDTO;
using WebAPI.DTO;
using WebAPI.DTO.ClassroomMapper;

namespace WebAPI.Controllers
{
    [Route("api/classroom")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public ClassroomController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassroomDTO>>> GetClassrooms()
        {
            if (_context.Classroom is null)
            {
                return NotFound();
            }
            return await _context.Classroom
                    .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClassroomDTO>> GetClasroom(int id)
        {
            if (_context.Classroom is null)
            {
                return NotFound();
            }
            return await _context.Classroom
                .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddClasroom(AddClassroomDTO classroomDTO)
        {
            var classroomDB = _mapper.Map<Classroom>(classroomDTO);
            _context.AddRange(classroomDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

    }
}
