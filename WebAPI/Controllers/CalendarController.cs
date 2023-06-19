using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/calendar")]
    [ApiController]
    [Authorize]
    public class CalendarController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGroupService _groupService;

        public CalendarController(ScheduleDbContext context, IMapper mapper, IGroupService groupService)
        {
            _context = context;
            _mapper = mapper;
            _groupService = groupService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CalendarDTO>>> GetCalendars()
        {
             if(_context.Calendar is null) return NotFound();

            return await _context.Calendar
                .ProjectTo<CalendarDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<CalendarDTO>> GetCalendar(int id)
        {
            if(_context.Calendar is null) return NotFound();
            return await _context.Calendar
                .ProjectTo<CalendarDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddCalendar(AddCalendarDTO calendarDTO)
        {
            var calendarExists = await _context.Calendar.AnyAsync(c => c.Period.ToLower() == calendarDTO.Period.ToLower());
            if (calendarExists) return Ok(new { isSuccess = false, errorType = 1 });
            var calendarDB = _mapper.Map<Calendar>(calendarDTO);
            calendarDB.CreatedDate = DateTime.Now;
            _context.Add(calendarDB);
            await _context.SaveChangesAsync();
            if (calendarDTO.NeedsCopy)
            {
                var groupsWereCopy = await _groupService.GenereteNewCalendar(_context, _mapper, calendarDTO.CalendarId, calendarDB.Id, calendarDTO.CreatedBy);
                if (!groupsWereCopy)
                {
                    _context.Remove(calendarDB);
                    return Ok(new { isSuccess = false, errorType = 4 });
                }
                await _context.SaveChangesAsync();
            }
            return Ok(new { isSuccess = true });

        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdatCalendar(EditCalendarDTO calendarDTO)
        {
            var calendarExists = await _context.Calendar.AnyAsync(c => c.Period.ToLower() == calendarDTO.Period.ToLower());
            if (calendarExists)
            {
                var calendarDB1 = await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == calendarDTO.Id);
                var isTheSame = calendarDB1.Period == calendarDTO.Period;
                if (isTheSame)
                {
                    calendarDB1 = _mapper.Map(calendarDTO, calendarDB1);
                    calendarDB1.UpdatedDate = DateTime.Now;
                    await _context.SaveChangesAsync();
                    return Ok(new { isSuccess = true });
                }
                else
                {
                    return Ok(new { isSuccess = false, errorType = 2 });
                }

            }
            var calendarDB2 = await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == calendarDTO.Id);
            calendarDB2 = _mapper.Map(calendarDTO, calendarDB2);
            calendarDB2.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpDelete("delete/{calendarId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteCalendar(int calendarId, int userId)
        {
            var calendarDB = await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == calendarId);
            if (calendarDB is null) { { return Ok(new { isSuccess = false, typeError = 2 }); } }
            calendarDB.DeletedBy = userId;
            calendarDB.DeletedDate = DateTime.Now;
            calendarDB.IsDeleted = true;
            var errasedGroups = await _groupService.DeleteGroupsByCalendar(_context, calendarId, userId);
            if (!errasedGroups) return Ok(new { isSuccess = false, errorType = 3 });
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }
    }
}
