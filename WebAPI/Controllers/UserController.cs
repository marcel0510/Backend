using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.ReadDTO;
using WebAPI.DTO.ValidateDTO;
using WebAPI.Secutiry;

namespace WebAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        public UserController(ScheduleDbContext context, IMapper mapper, ITokenService tokenService)
        {
            _context = context;
            _mapper = mapper;
            _tokenService = tokenService;
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
        public async Task<ActionResult> AddUser(AddUserDTO userDTO)
        {
            var userExists = await _context.User.AnyAsync(u => u.Email.ToLower() == userDTO.Email.ToLower());
            if (userExists) return BadRequest(new
            {
                isSuccess = false,
                Message = "Este usuario ya está registrado"
            });
            var userDB = _mapper.Map<User>(userDTO);
            _context.Add(userDB);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                isSuccess = true,
                Message = "Usuario registrado correctamente"
            });
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

        [HttpPost("validate")]
        public async Task<ActionResult> ValidateUser(ValidateUserDTO userDTO)
        {
            var userDB = await _context.User.FirstOrDefaultAsync(u => u.Email == userDTO.Email);
            if (userDB is null) return Unauthorized(new {
                isSuccess = false,
            });

            if (BCrypt.Net.BCrypt.Verify(userDTO.Password, userDB.Password))
            {
                var token = _tokenService.GetToken(userDB);
                var user = _mapper.Map<UserDTO>(userDB);
                return Ok(new
                {
                    isSuccess = true,
                    token,
                    user.Id,
                    user.Name,
                    user.Role,
                });
            }
            else return Ok(new
            {
                isSuccess = false,
            }) ;
        }
    }
}
