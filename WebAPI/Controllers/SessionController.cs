using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using WebAPI.AddDTO.AddGroupMapper;
using WebAPI.DTO;
using WebAPI.EditDTO;

namespace WebAPI.Controllers
{
    [Route("api/session")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public SessionController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPut("update")]
        public async Task<ActionResult> UpdateSession(EditSessionDTO[] sessions)
        {
            foreach (var session in sessions)
            {
                var sessionDB = _context.Session.AsTracking().FirstOrDefault(s => s.Id == session.Id);
                sessionDB = _mapper.Map(session, sessionDB);
            }

            await _context.SaveChangesAsync();
            return Ok(true);
        }

        
    }
}
