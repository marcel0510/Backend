using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Model;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using WebAPI.DTO;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.GroupMapper;

namespace WebAPI.Controllers
{
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public GroupController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupDTO>>> GetGroups()
        {
            if (_context.Group == null) { return NotFound(); }
            return await _context.Group
                .ProjectTo<GroupDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GroupDTO>> GetGroup(int id)
        {
            if (_context.Group is null) { return NotFound(); }
            return await _context.Group
                .ProjectTo<GroupDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(g => g.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult<bool>> AddGroup(AddGroupDTO groupERD)
        {
            var group = _mapper.Map<Group>(groupERD);
            _context.Entry(group.Subject).State = EntityState.Unchanged;        
            _context.Entry(group.Classroom).State = EntityState.Unchanged;
            _context.Add(group);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpPut("update/{id:int}")]
        public async Task<ActionResult<bool>> UndateGroup(int id, EditGroupDTO groupDTO)
        {
            var groupDB = await _context.Group.AsTracking().FirstOrDefaultAsync(g => g.Id == id);
            if(groupDB is null) { return NotFound(); }
            groupDB = _mapper.Map(groupDTO, groupDB);
            await _context.SaveChangesAsync();
            return Ok(true);
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
