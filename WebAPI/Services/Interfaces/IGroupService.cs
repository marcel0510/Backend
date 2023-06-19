using AutoMapper;
using Model;

namespace WebAPI.Services.Interfaces
{
    public interface IGroupService
    {
        public Task<bool> DeleteGroupsByCalendar(ScheduleDbContext context, int calendarId, int userId);
        public Task<bool> GenereteNewCalendar(ScheduleDbContext context, IMapper mapper, int IdOldCalendar, int IdNewCalendar, int userId);
    }
}
