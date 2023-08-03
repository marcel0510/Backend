using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO;

namespace WebAPI.Controllers
{
    [Route("api/calendar")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarDAL _calendarDAL;
        private readonly IMapper _mapper;

        public CalendarController(ICalendarDAL calendarDAL, IMapper mapper)
        {
            _calendarDAL = calendarDAL;
            _mapper = mapper;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CalendarDTO>>> GetCalendars()
        {
            var Calendars = _calendarDAL.GetAll();
            return await Calendars.ProjectTo<CalendarDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<CalendarDTO>> GetCalendar(int id)
        {
            var Calendars = _calendarDAL.GetAll(); ;
            return await Calendars.ProjectTo<CalendarDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddCalendar(AddCalendarDTO calendarDTO)
        {
            var calendar = _mapper.Map<Calendar>(calendarDTO);
            var request = await _calendarDAL.Add(calendar, calendarDTO.NeedsCopy, calendarDTO.CalendarId);
            if(request.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = request.ErrorType });

        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdatCalendar(EditCalendarDTO calendarDTO)
        {
            var calendar = await _calendarDAL.Get(calendarDTO.Id);
            calendar = _mapper.Map(calendarDTO, calendar);
            var request = await _calendarDAL.Update(calendar);
            if (request.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = request.ErrorType });
        }

        [HttpDelete("delete/{calendarId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteCalendar(int calendarId, int userId)
        {
            var ok = await _calendarDAL.Delete(calendarId, userId);
            return Ok(new { isSuccess = ok });
            
        }
    }
}
