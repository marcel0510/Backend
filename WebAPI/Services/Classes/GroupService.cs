using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.ReadDTO.ClassroomMapper;
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

        public async Task<bool> DeleteGroupsByClassroom(ScheduleDbContext context, int classroomId, int userId)
        {
            var groupsDB = await context.Group.AsTracking().Where(g => g.ClassroomId == classroomId).ToListAsync();
            if (groupsDB == null) return false;
            groupsDB.ForEach(g =>
            {
                g.IsDeleted = true;
                g.DeletedBy = userId;
                g.DeletedDate = DateTime.Now;
            });

            return true;
        }

        public async Task<bool> DeleteGroupsBySubject(ScheduleDbContext context, int subjectId, int userId)
        {
            var groupsDB = await context.Group.AsTracking().Where(g => g.SubjectId == subjectId).ToListAsync();
            if (groupsDB == null) return false;
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
        public bool ValidateRepitedNames(List<CGroupDTO> groups, int subjectId, string name)
        {
            foreach(var group in groups)
            {
                if(group.Subject.Id == subjectId)
                {
                    if(group.Name == name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public List<int> ValidateOverlappingSchedules(ClassroomDTO classroom, List<AddSessionDTO> sessions)
        {
            var Schedule = new int[13, 5]; //13 filas y 5 columnas
            var sessionsSchedule = new int[13, 5]; //13 filas y 5 columnas
            var result = new List<int>();
            //Llenar la matriz como vacia
            for (int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Schedule[i, j] = 0;
                    sessionsSchedule[i, j] = 0;
                }
            }
            //Llena la matriz con los grupos del aula
            foreach (var group in classroom.Groups) {
                foreach(var session in group.Sessions)
                {
                    var startHour = int.Parse(session.StartTime.Substring(0, 2));
                    var endHour = int.Parse(session.EndTime.Substring(0, 2));
                    var duration = endHour - startHour;
                    
                    for(int i = 0; i < duration; i++)
                    {
                        var row = startHour - 7 + i;
                        var col = (int)session.Day;
                        Schedule[row, col] = group.Id;
                    }
                }
            }
            //Llenar la matriz con el nuevo grupo
            foreach(var session in sessions)
            {
                var startHour = int.Parse(session.StartTime.Substring(0, 2));
                var endHour = int.Parse(session.EndTime.Substring(0, 2));
                var duration = endHour - startHour;

                for (int i = 0; i < duration; i++)
                {
                    var row = startHour - 7 + i;
                    var col = (int)session.Day;
                    sessionsSchedule[row, col] = -1;
                }
            } 
            //Comparar que ningun grupo se sobrelape
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Schedule[i, j] != 0)
                      if (sessionsSchedule[i, j] == -1) result.Add(Schedule[i, j]);
                    
                }
            }

            return result;
        }

        
    }
}
