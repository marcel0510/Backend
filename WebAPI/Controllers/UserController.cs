using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using Model.Enum;
using Newtonsoft.Json.Linq;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
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
            var userRoleExists = await _context.User.AnyAsync(u => u.Role == userDTO.Role);
            if (userExists) return Ok(new { isSuccess = false, errorType = 1 });
            if (userRoleExists) return Ok(new { isSuccess = false, errorType = 2 });
            var userDB = _mapper.Map<User>(userDTO);
            _context.Add(userDB);
            await _context.SaveChangesAsync();
            var token = _tokenService.GetToken(userDB);
            var user = await _context.User.FirstOrDefaultAsync(u => u.Email == userDTO.Email);
            return Ok(new
            {
                isSuccess = true,
                token,
                user.Id,
                user.Name,
                user.Role,
            });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateUser(UserDTO userDTO)
        {

            var userMailExists = await _context.User.AnyAsync(u => u.Email.ToLower() == userDTO.Email.ToLower() && u.Id != userDTO.Id);
            var userRoleExists = await _context.User.AnyAsync(u => u.Role == userDTO.Role && userDTO.Role != Role.Admin && u.Id != userDTO.Id );


            if (userMailExists) return Ok(new { isSuccess = false, errorType = 1 });
            if (userRoleExists) return Ok(new { isSuccess = false, errorType = 2 });

            var userDB = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == userDTO.Id);
            userDB = _mapper.Map(userDTO, userDB);
            userDB.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });


        }

        [HttpDelete("delete/{usrId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteUser(int usrId, int userId)
        {
            var userDB = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == usrId);
            if (usrId == 1) return Ok(new { isSuccess = false, errorType = 0 });
            userDB.IsDeleted = true;
            userDB.DeletedDate = DateTime.Now;
            userDB.DeletedBy = userId;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }


        [HttpPut("update/password/")]
        public async Task<ActionResult> UpdatePasswordUser(EditPassword password)
        {
            var userDB = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == password.UserId);

            if (password.IsRestore)
            {
                userDB.Password = password.NewPassword;
                userDB.Reset = true;
                await _context.SaveChangesAsync();
                return Ok(new { isSuccess = true });
            }

            if(password.OldPassword != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password.OldPassword, userDB.Password))
                {
                    if (BCrypt.Net.BCrypt.Verify(password.NewPassword, userDB.Password))
                    {
                        return Ok(new { isSuccess = false, errorType = 4 });
                    }

                    userDB.Password = password.NewPassword;
                    await _context.SaveChangesAsync();
                    return Ok(new { isSuccess = true });
                }
                else return Ok(new { isSuccess = false, errorType = 3 });
            }

            userDB.Password = password.NewPassword;
            userDB.Reset = false;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });

        }

       
        [HttpPost("validate")]
        public async Task<ActionResult> ValidateUser(ValidateUserDTO userDTO)
        {
            var userDB = await _context.User.FirstOrDefaultAsync(u => u.Email == userDTO.Email);
 
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
                    user.Reset
                });
            }
            else return Ok(new
            {
                isSuccess = false,
            }) ;
        }
    }
}
