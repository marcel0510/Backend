using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.ReadDTO.GroupMapper;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services.Classes
{
    public class GroupService : IGroupService

    {
        public async Task<bool> DeleteGroupsByCalendar(ScheduleDbContext context, int calendarId, int userId)
        {
            var groupsDB = await context.Group.AsTracking().Where(g => g.CalendarId == calendarId).ToListAsync();
            if(groupsDB == null) return false;
            groupsDB.ForEach(g =>
            {
                g.IsDeleted = true;
                g.DeletedBy = userId;
                g.DeletedDate = DateTime.Now;
            });

            return true;
        }

        public async Task<bool> GenereteNewCalendar(ScheduleDbContext context, IMapper mapper, int IdOldCalendar, int IdNewCalendar, int userId)
        {
            var groupsDto = await context.Group.AsNoTracking()
                .ProjectTo<GroupDTO>(mapper.ConfigurationProvider)
                .ProjectTo<AddGroupDTO>(mapper.ConfigurationProvider)
                .Where(g => g.CalendarId == IdOldCalendar)
                .ToListAsync();

            foreach (var group in groupsDto)
            {
                context.ChangeTracker.Clear();
                group.CalendarId = IdNewCalendar;
                var g = mapper.Map<Group>(group);
                g.Id = 0;
                context.Entry(g).State = EntityState.Detached;
                context.Entry(g.Calendar).State = EntityState.Unchanged;
                context.Entry(g.Classroom).State = EntityState.Unchanged;
                context.Entry(g.Subject).State = EntityState.Unchanged;

                context.Add(g);
                await context.SaveChangesAsync();

            }

            return true;
        }
    }
}
