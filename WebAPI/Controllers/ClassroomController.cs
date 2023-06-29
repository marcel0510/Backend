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
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/classroom")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGroupService _groupService;

        public ClassroomController(ScheduleDbContext context, IMapper mapper, IGroupService groupService)
        {
            _context = context;
            _mapper = mapper;
            _groupService = groupService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralClassroomDTO>>> GetClassrooms()
        {
            if (_context.Classroom is null) { return NotFound(); }
            return await _context.Classroom
                    .ProjectTo<GeneralClassroomDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
        [HttpGet("byCalendar/{calendarId:int}")]
        public async Task<ActionResult<IEnumerable<ClassroomDTO>>> GetClassroomsByCalendar(int calendarId)
        {
            var classrooms = await _context.Classroom
                .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).ToArrayAsync();
            var filteredClassrooms = new List<ClassroomDTO>();

            foreach (var classroom in classrooms)
            {
                var filteredGroups = classroom.Groups.Where(g => g.CalendarId == calendarId).ToList();
                var filteredClassroom = new ClassroomDTO()
                {
                    Id = classroom.Id,
                    Code = classroom.Code,
                    Name = classroom.Name,
                    Capacity = classroom.Capacity,
                    Floor = classroom.Floor,
                    Building = classroom.Building,
                    Groups = filteredGroups
                };
                filteredClassrooms.Add(filteredClassroom);
            }
            return filteredClassrooms;
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClassroomDTO>> GetClassroom(int id)
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
            if (!classroomDTO.IsLab) classroomDB.Name = null;
            _context.Entry(classroomDB.Building).State = EntityState.Unchanged;
            _context.Add(classroomDB);
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateClassroom(EditClassroomDTO classroomDTO)
        {
            var classroomsDB = await _context.Classroom.ProjectTo<GeneralClassroomDTO>(_mapper.ConfigurationProvider)
                .Where(c => c.Building.Id == classroomDTO.BuildingId).ToListAsync();
            var classroomExists = classroomsDB.Any(c => c.Code.ToLower() == classroomDTO.Code.ToLower()
                                                    && c.Floor.ToLower() == classroomDTO.Floor.ToLower());
            if (classroomExists)
            {
                var classroomDB1 = await _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == classroomDTO.Id);
                var isTheSame = classroomDTO.Code == classroomDB1.Code;
                if (isTheSame)
                {
                    classroomDB1 = _mapper.Map(classroomDTO, classroomDB1);
                    classroomDB1.UpdatedDate = DateTime.Now;
                    if (!classroomDTO.IsLab) classroomDB1.Name = null;
                    _context.Entry(classroomDB1.Building).State = EntityState.Unchanged;
                    await _context.SaveChangesAsync();
                    return Ok(new { isSuccess = true });
                }
                else
                {
                    return Ok(new { isSuccess = false, errorType = 2 });
                }

            }
            var classroomDB = await _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == classroomDTO.Id);
            classroomDB = _mapper.Map(classroomDTO, classroomDB);
            classroomDB.UpdatedDate = DateTime.Now;
            if (!classroomDTO.IsLab) classroomDB.Name = null;
            _context.Entry(classroomDB.Building).State = EntityState.Unchanged;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpDelete("delete/{classroomId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteClassroom(int classroomId, int userId)
        {
            var classroomDB = await _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == classroomId);
            if (classroomDB is null) { return Ok(new { isSuccess = false, typeError = 0 }); }
            classroomDB.DeletedBy = userId;
            classroomDB.DeletedDate = DateTime.Now;
            classroomDB.IsDeleted = true;
            var errasedGroups = await _groupService.DeleteGroupsByClassroom(_context, classroomId, userId);
            if (!errasedGroups) return Ok(new { isSuccess = false, errorType = 3 });
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }
    }
}
