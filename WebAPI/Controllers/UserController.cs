using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.AddDTO;
using WebAPI.DTO;

namespace WebAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public UserController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            if (_context.Building is null) { return NotFound(); }
            return await _context.User
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider).ToArrayAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id)
        {
            if (_context.User is null) { return NotFound(); }
            var user = await _context.User.FirstOrDefaultAsync(u => u.Id == id);
            var UserDTO = _mapper.Map<UserDTO>(user);
            return UserDTO;
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddBuilding(AddUserDTO userDTO)
        {
            var userDB = _mapper.Map<User>(userDTO);
            _context.AddRange(userDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpPut("update/{id:int}")]
        public async Task<ActionResult> UpdateUser(int id, UserDTO userDTO)
        {
            var userDB = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == id);
            if (userDB is null) { return NotFound(); }
            userDB = _mapper.Map(userDTO, userDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpPut("update/password/{id:int}")]
        public async Task<ActionResult> UpdatePasswordUser(int id, AddUserDTO userDTO)
        {
            var userDB = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == id);
            if (userDB is null) { return NotFound(); }
            userDB = _mapper.Map(userDTO, userDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var userDB = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == id);
            if (userDB is null) { return NotFound(); }
            userDB.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(true);
        }
    }
}
