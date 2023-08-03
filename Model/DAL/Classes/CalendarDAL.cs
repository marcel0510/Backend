using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;


namespace Model.DAL.Classes
{
    public class CalendarDAL : ICalendarDAL
    {
        readonly private ScheduleDbContext _context;

        public CalendarDAL(ScheduleDbContext context)
        {
            _context = context;
        }
        public DbSet<Calendar> GetAll()
        {
            return _context.Calendar;
        }
        public async Task<Calendar> Get(int id)
        {
            return await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Request> Add(Calendar newCalendar, bool NeedsCopy, int oldCalendarId)
        {
            var request = new Request();
            var doesCalendarExist = await _context.Calendar.AnyAsync(c => c.Period.ToLower() == newCalendar.Period.ToLower());
            if (doesCalendarExist)
            {
                request.Ok = false;
                request.ErrorType = 1;
                return request;
            }
            newCalendar.CreatedDate = DateTime.Now;
            _context.Add(newCalendar);
            await _context.SaveChangesAsync();

            if (NeedsCopy)
            {
                var Groups = await _context.Group.Include(g => g.Sessions)
                                                 .Include(g => g.Calendar)
                                                 .Include(g => g.Classroom)
                                                 .Include(g => g.Subject).Where(g => g.CalendarId == oldCalendarId).ToListAsync();
                foreach(var group in Groups)
                {
                    _context.ChangeTracker.Clear();
                    var copySessions = new List<Session>();
                    foreach (var session in group.Sessions)
                    {
                        var newSession = new Session()
                        {
                            Day = session.Day,
                            StartTime = session.StartTime,
                            EndTime = session.EndTime
                        };
                        copySessions.Add(newSession);
                    }
                    var copyGroup = new Group() { 
                        Name = group.Name,
                        Classroom = group.Classroom,
                        Subject = group.Subject,
                        Calendar = newCalendar,
                        Sessions = copySessions
                    };

                    _context.Entry(copyGroup.Calendar).State = EntityState.Unchanged;
                    _context.Entry(copyGroup.Classroom).State = EntityState.Unchanged;
                    _context.Entry(copyGroup.Subject).State = EntityState.Unchanged;

                    _context.Add(copyGroup);
                    await _context.SaveChangesAsync();

                }
            }

            request.Ok = true;
            return request;
        }
        public async Task<Request> Update(Calendar updatedCalendar)
        {
            var request = new Request();
            var doesCalendarExists = await _context.Calendar.AnyAsync(c => c.Period.ToLower() == updatedCalendar.Period.ToLower() && c.Id != updatedCalendar.Id);
            if (doesCalendarExists)
            {
                request.Ok = false;
                request.ErrorType = 2;
                return request;
            }

            updatedCalendar.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            request.Ok = true;
            return request;
        }

        public async Task<bool> Delete(int calendarId, int userId)
        {
            var calendar = await _context.Calendar.AsTracking().FirstOrDefaultAsync(c => c.Id == calendarId);
            calendar.DeletedBy = userId;
            calendar.DeletedDate = DateTime.Now;
            calendar.IsDeleted = true;
            var Groups = await _context.Group.AsTracking().Where(g => g.CalendarId == calendarId).ToListAsync();
            foreach(var group in Groups) {
                group.IsDeleted = true;
                group.DeletedBy = userId;
                group.DeletedDate = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            return true;

        }

        

    }
}
