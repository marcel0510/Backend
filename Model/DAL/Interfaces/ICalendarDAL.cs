using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.DAL.Interfaces
{
    public interface ICalendarDAL
    {
        public DbSet<Calendar> GetAll();
        public Task<Calendar> Get(int id);
        public Task<Request> Add(Calendar newCalendar, bool NeedsCopy, int oldCalendarId);
        public Task<Request> Update(Calendar updatedCalendar);
        public Task<bool> Delete(int calendarId, int userId);
    }
}
