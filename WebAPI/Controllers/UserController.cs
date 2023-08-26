using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO;
using WebAPI.DTO.ValidateDTO;
using WebAPI.Secutiry;

namespace WebAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserDAL _userDAL;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public UserController(IUserDAL userDAL, ITokenService tokenService, IMapper mapper)
        {
            _userDAL = userDAL;
            _tokenService = tokenService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            var Users = _userDAL.GetAll();
            return await Users.ProjectTo<UserDTO>(_mapper.ConfigurationProvider).ToArrayAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id)
        {
            var User = await _userDAL.GetById(id);
            var UserDTO = _mapper.Map<UserDTO>(User);
            return UserDTO;
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddUser(ManUserDTO userDTO)
        {

            var user = _mapper.Map<User>(userDTO);
            var response = await _userDAL.Add(user);

            if (response.Ok)
            {
                var User = await _userDAL.GetByEmail(userDTO.Email);
                var token = _tokenService.GetToken(User);
                return Ok(new
                {
                    isSuccess = true,
                    token,
                    User.Id,
                    User.Name,
                    User.Role,
                });
            }
            else
            {
                return Ok(new { isSuccess = false, errorType = response.ErrorType });
            }

        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateUser(ManUserDTO userDTO)
        {

            var user = await _userDAL.GetForUpdate((int)userDTO.Id);
            user = _mapper.Map(userDTO, user);
            var response = await _userDAL.Update(user);

            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }

        [HttpDelete("delete/{usrId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteUser(int usrId, int userId)
        {
            var ok = await _userDAL.Delete(usrId, userId);
            if (ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = 0 });
        }


        [HttpPut("update/password/")]
        public async Task<ActionResult> UpdatePasswordUser(ManPasswordDTO password)
        {

            if (password.IsRestore)
            {
                var OK = _userDAL.RestorePassword(password.UserId, password.NewPassword, true);
                return Ok(new { isSuccess = OK });
            }

            if (password.OldPassword != null)
            {
                var response = await _userDAL.ChangePassword(password.UserId, password.OldPassword, password.NewPassword);
                if (response.Ok) return Ok(new { isSuccess = true });
                else Ok(new { isSuccess = false, errorType = response.ErrorType });
            }

            var ok = await _userDAL.RestorePassword(password.UserId, password.NewPassword, false);
            return Ok(new { isSuccess = ok });

        }


        [HttpPost("validate")]
        public async Task<ActionResult> ValidateUser(ValidateUserDTO userDTO)
        {
            var user = await _userDAL.Validate(userDTO.Email, userDTO.Password);

            if (user.IsDeleted) return Ok(new { isSuccess = false, errorType = user.Id });

            var token = _tokenService.GetToken(user);
            var usr = _mapper.Map<UserDTO>(user);
            return Ok(new
            {
                isSuccess = true,
                token,
                usr.Id,
                usr.Name,
                usr.Role,
                usr.Reset
            });

        }
    }
}
