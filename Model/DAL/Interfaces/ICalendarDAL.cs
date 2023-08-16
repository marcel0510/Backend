using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.DAL.Interfaces
{
    public interface ICalendarDAL
    {
        public DbSet<Calendar> GetAll();
        public Task<Calendar> GetForUpdate(int id);
        public Task<Response> Update(Calendar updatedCalendar);
        public Task<Response> Add(Calendar newCalendar, bool NeedsCopy, int oldCalendarId);
        public Task<bool> Delete(int calendarId, int userId);
    }
}
