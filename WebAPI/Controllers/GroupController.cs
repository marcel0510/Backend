using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.GroupMapper;
using Model.DAL.Interfaces;

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
        [HttpGet]
        public async Task<IEnumerable<GeneralGroupDTO>> GetGroups()
        {
            var Groups = _groupDAL.GetAll();
            return await Groups.ProjectTo<GeneralGroupDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GroupDTO>> GetGroup(int id)
        {
            var Groups = _groupDAL.GetAll();
            return await Groups.ProjectTo<GroupDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(g => g.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult<bool>> AddGroup(AddGroupDTO groupDTO)
        {
            var group = _mapper.Map<Group>(groupDTO);
            var request = await _groupDAL.Add(group);

            if(request.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = request.ErrorType, overlappingGrs = request.Groups.Distinct() });
        }

        [HttpPut("update")]
        public async Task<ActionResult<bool>> UpdateGroup(EditGroupDTO groupDTO)
        {
            var group = await _groupDAL.Get(groupDTO.Id);
            var updatedSessions = _mapper.Map<List<Session>>(groupDTO.Sessions);
            group = _mapper.Map(groupDTO, group);
            group.Sessions.Clear();
            group.Sessions = updatedSessions;
            var request = await _groupDAL.Update(group);

            if (request.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = request.ErrorType, overlappingGrs = request.Groups.Distinct() });

        }

        [HttpDelete("delete/{groupId:int}/{userId:int}")]
        public async Task<ActionResult<bool>> DeleteGroup(int groupId, int userId)
        {
            var ok = await _groupDAL.Delete(groupId, userId);
            return Ok(new { isSuccess = ok });
        }

    }
}
