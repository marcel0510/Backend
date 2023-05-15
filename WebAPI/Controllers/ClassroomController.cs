using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
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
        public async Task<ActionResult<IEnumerable<ClassroomDTO>>> GetSubjects()
        {
            if (_context.Classroom == null)
            {
                return NotFound();
            }
            return await _context.Classroom
                    .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
