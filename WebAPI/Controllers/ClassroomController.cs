using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.ClassroomMapper;

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
        public async Task<ActionResult<IEnumerable<GeneralClassroomDTO>>> GetClassrooms()
        {
            if (_context.Classroom is null) { return NotFound(); }
            return await _context.Classroom
                    .ProjectTo<GeneralClassroomDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClassroomDTO>> GetClasroom(int id)
        {
            if (_context.Classroom is null) { return NotFound(); }
            return await _context.Classroom
                .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddClasroom(AddClassroomDTO classroomDTO)
        {
            var classroomsDB = await _context.Classroom.ProjectTo<GeneralClassroomDTO>(_mapper.ConfigurationProvider)
                .Where(c => c.Building.Id == classroomDTO.BuildingId).ToListAsync();
            var classroomExists = classroomsDB.Any(c => c.Code.ToLower() == classroomDTO.Code.ToLower()
                                                    && c.Floor.ToLower() == classroomDTO.Floor.ToLower());
            if (classroomExists) return Ok(new { isSuccess = false, errorType = 1 });
            var classroomDB = _mapper.Map<Classroom>(classroomDTO);
            classroomDB.CreatedBy = classroomDTO.CreatedBy;
            classroomDB.CreatedDate = DateTime.Now;
            _context.Entry(classroomDB.Building).State = EntityState.Unchanged;
            _context.Add(classroomDB);
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpPut("update/{id:int}")]
        public async Task<ActionResult> UpdateClassroom(int id, EditClassroomDTO classroomDTO)
        {
            var classroomDB = await _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == id);
            if (classroomDB is null) { return NotFound(); }
            classroomDB = _mapper.Map(classroomDTO, classroomDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> DeleteClassroom(int id)
        {
            var classroomDB = await _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == id);
            if (classroomDB is null) { return NotFound(); }
            classroomDB.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(true);
        }
    }
}
