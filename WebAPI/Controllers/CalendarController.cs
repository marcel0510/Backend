using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.ReadDTO;

namespace WebAPI.Controllers
{
    [Route("api/calendar")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public CalendarController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarDTO>>> GetCalendars()
        {
            if(_context.Calendar is null) return NotFound();

            return await _context.Calendar
                .ProjectTo<CalendarDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CalendarDTO>> GetCalendar(int id)
        {
            if(_context.Calendar is null) return NotFound();
            return await _context.Calendar
                .ProjectTo<CalendarDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddCalendar(AddCalendarDTO calendarDTO)
        {
            var calendarDB = _mapper.Map<Calendar>(calendarDTO);
            _context.Add(calendarDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpPut("update/{id:int}")]
        public async Task<ActionResult> UpdatCalendar(int id, CalendarDTO calendarDTO)
        {
            var calendarDB = await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == id);
            if (calendarDB is null) { return NotFound(); }
            calendarDB = _mapper.Map(calendarDTO, calendarDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> DeleteCalendar(int id)
        {
            var calendarDB = await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == id);
            if (calendarDB is null) { return NotFound(); }
            calendarDB.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(true);
        }
    }
}
