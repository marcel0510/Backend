using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Model;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.GroupMapper;
using WebAPI.DTO.AddDTO;
using WebAPI.Services.Interfaces;
using WebAPI.DTO.ReadDTO.ClassroomMapper;

namespace WebAPI.Controllers
{
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGroupService _groupService;

        public GroupController(ScheduleDbContext context, IMapper mapper, IGroupService groupService)
        {
            _context = context;
            _mapper = mapper;
            _groupService = groupService;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralGroupDTO>>> GetGroups()
        {
            if (_context.Group == null) { return NotFound(); }
            return await _context.Group
                .ProjectTo<GeneralGroupDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GroupDTO>> GetGroup(int id)
        {
            if (_context.Group is null) { return NotFound(); }
            return await _context.Group
                .ProjectTo<GroupDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(g => g.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult<bool>> AddGroup(AddGroupDTO groupDTO)
        {
            var classroomDTO = await _context.Classroom
                .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == groupDTO.ClassroomId);

            var groupExists = _groupService.ValidateRepitedNames(classroomDTO.Groups, groupDTO.SubjectId, groupDTO.Name);
            if (groupExists) return Ok(new { isSuccess = false, errorType = 1 });
            var overlappingExists = _groupService.ValidateOverlappingSchedules(classroomDTO, groupDTO.Sessions);
            if(overlappingExists.Count != 0) return Ok(new {isSuccess = false, errorType = 2, overlappingGrs = overlappingExists.Distinct() });
            var group = _mapper.Map<Group>(groupDTO);
            _context.Entry(group.Subject).State = EntityState.Unchanged;        
            _context.Entry(group.Classroom).State = EntityState.Unchanged;
            _context.Entry(group.Calendar).State = EntityState.Unchanged;
            _context.Add(group);
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpPut("update")]
        public async Task<ActionResult<bool>> UpdateGroup(EditGroupDTO groupDTO)
        {
            var classroomDTO = await _context.Classroom
                .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == groupDTO.ClassroomId);
            var groupExists = _groupService.ValidateRepitedNames(classroomDTO.Groups, groupDTO.SubjectId, groupDTO.Name);

            if(groupExists)
            {
                var groupDB1 = await _context.Group.AsTracking().Include(g => g.Sessions).FirstOrDefaultAsync(g => g.Id == groupDTO.Id);
                var isTheSame = groupDB1.SubjectId == groupDTO.SubjectId && groupDB1.Name == groupDTO.Name;
                if(isTheSame)
                {

                    var updatedSessions1 = _mapper.Map<List<Session>>(groupDTO.Sessions);
                    groupDB1 = _mapper.Map(groupDTO, groupDB1);
                    groupDB1.Sessions.Clear();
                    groupDB1.Sessions = updatedSessions1;
                    groupDB1.UpdatedDate = DateTime.Now;
                    _context.Entry(groupDB1.Subject).State = EntityState.Unchanged;
                    _context.Entry(groupDB1.Classroom).State = EntityState.Unchanged;
                    _context.Entry(groupDB1.Calendar).State = EntityState.Unchanged;
                    await _context.SaveChangesAsync();
                    return Ok(new { isSuccess = true });
                }
                else
                {
                    return Ok(new { isSuccess = false, errorType = 1 });
                }
            }

            var groupDB = await _context.Group.AsTracking().Include(g => g.Sessions).FirstOrDefaultAsync(g => g.Id == groupDTO.Id);
            var updatedSessions = _mapper.Map<List<Session>>(groupDTO.Sessions);
            groupDB = _mapper.Map(groupDTO, groupDB);
            groupDB.Sessions.Clear();
            groupDB.Sessions = updatedSessions;
            groupDB.UpdatedDate = DateTime.Now;
            _context.Entry(groupDB.Subject).State = EntityState.Unchanged;
            _context.Entry(groupDB.Classroom).State = EntityState.Unchanged;
            _context.Entry(groupDB.Calendar).State = EntityState.Unchanged;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });


        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult<bool>> DeleteGroup(int id)
        {
            var groupDb = await _context.Group.AsTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (groupDb is null) { return NotFound(); }
            groupDb.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(true);
        }
      
    }
}
