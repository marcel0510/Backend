using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using WebAPI.DTO.QueryDTO.GroupMapper;
using Model.DAL.Interfaces;
using WebAPI.DTO.ManDTO;

namespace WebAPI.Controllers
{
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupDAL _groupDAL;
        private readonly IMapper _mapper;

        public GroupController(IGroupDAL groupDAL, IMapper mapper)
        {
            _groupDAL = groupDAL;
            _mapper = mapper;
        }

        // GET: api/Courses
        [HttpGet("{calendarId:int}")]
        public async Task<IEnumerable<GeneralGroupDTO>> GetGroups(int calendarId)
        {
            var Groups = _groupDAL.GetAll();
            return await Groups.ProjectTo<GeneralGroupDTO>(_mapper.ConfigurationProvider)
                .Where(g => g.Calendar.Id == calendarId)
                .ToListAsync();
        }

        [HttpGet("get/{id:int}")]
        public async Task<ActionResult<GroupDTO>> GetGroup(int id)
        {
            var Groups = _groupDAL.GetAll();
            return await Groups.ProjectTo<GroupDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(g => g.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult<bool>> AddGroup(ManGroupDTO groupDTO)
        {
            var group = _mapper.Map<Group>(groupDTO);
            var response = await _groupDAL.Add(group);

            if(response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType, overlappingGrs = response.Groups.Distinct() });
        }

        [HttpPut("update")]
        public async Task<ActionResult<bool>> UpdateGroup(ManGroupDTO groupDTO)
        {
            var group = await _groupDAL.GetForUpdate((int)groupDTO.Id);
            var updatedSessions = _mapper.Map<List<Session>>(groupDTO.Sessions);
            group = _mapper.Map(groupDTO, group);
            group.Sessions.Clear();
            group.Sessions = updatedSessions;
            var response = await _groupDAL.Update(group);

            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType, overlappingGrs = response.Groups.Distinct() });

        }

        [HttpDelete("delete/{groupId:int}/{userId:int}")]
        public async Task<ActionResult<bool>> DeleteGroup(int groupId, int userId)
        {
            var ok = await _groupDAL.Delete(groupId, userId);
            return Ok(new { isSuccess = ok });
        }

    }
}
