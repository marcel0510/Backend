using Model.Entities;
using Model.Enum;
using Model.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Model.DAL.Classes
{
    public class GroupDAL : IGroupDAL
    {
        readonly private ScheduleDbContext _context;

        public GroupDAL(ScheduleDbContext context)
        {
            _context = context;
        }
        public DbSet<Group> GetAll()
        {
            return  _context.Group;
        }

        public async Task<Group> GetForUpdate(int id)
        {
            return await _context.Group.AsTracking().Include(g => g.Sessions).FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Response> Add(Group newGroup)
        {
            var response = new Response();
            var classroom = await _context.Classroom.Include(c => c.Groups).ThenInclude(g => g.Sessions)
                .FirstOrDefaultAsync(c => c.Id == newGroup.Classroom.Id);

            var doesGroupExist = ValidateRepitedNames(classroom.Groups, newGroup.Subject.Id, newGroup.Name, 0, false);
            if (doesGroupExist)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }
            var groupOnThursday = ValidateNoThursday(newGroup.Sessions);
            if (groupOnThursday)
            {
                response.Ok = false;
                response.ErrorType = 3;
                return response;
            }
            var doesOverlappingExist = ValidateOverlappingSchedules(classroom, newGroup.Sessions, 0, false);
            if(doesOverlappingExist.Count != 0)
            {
                response.Ok = false;
                response.ErrorType = 2;
                response.Groups = doesOverlappingExist;
                return response;
            }


            newGroup.CreatedDate = DateTime.Now;

            _context.Entry(newGroup.Subject).State = EntityState.Unchanged;
            _context.Entry(newGroup.Classroom).State = EntityState.Unchanged;
            _context.Entry(newGroup.Calendar).State = EntityState.Unchanged;

            _context.Add(newGroup);
            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;
        }

        public async Task<Response> Update(Group updatedGroup)
        {
            var response = new Response();
            var classroom = await _context.Classroom.Include(c => c.Groups).ThenInclude(g => g.Sessions)
                .FirstOrDefaultAsync(c => c.Id == updatedGroup.Classroom.Id);

            var doesGroupExist = ValidateRepitedNames(classroom.Groups, updatedGroup.Subject.Id, updatedGroup.Name, updatedGroup.Id, true);
            if (doesGroupExist)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }
            var groupOnThursday = ValidateNoThursday(updatedGroup.Sessions);
            if (groupOnThursday)
            {
                response.Ok = false;
                response.ErrorType = 3;
                return response;
            }
            var doesOverlappingExist = ValidateOverlappingSchedules(classroom, updatedGroup.Sessions, updatedGroup.Id, true);
            if (doesOverlappingExist.Count != 0)
            {
                response.Ok = false;
                response.ErrorType = 2;
                response.Groups = doesOverlappingExist;
                return response;
            }

            updatedGroup.UpdatedDate = DateTime.Now;

            _context.Entry(updatedGroup.Subject).State = EntityState.Unchanged;
            _context.Entry(updatedGroup.Classroom).State = EntityState.Unchanged;
            _context.Entry(updatedGroup.Calendar).State = EntityState.Unchanged;

            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;
        }

        public async Task<bool> Delete(int groupId, int userId)
        {
            var group = await _context.Group.AsTracking().FirstOrDefaultAsync(g => g.Id == groupId);
            group.IsDeleted = true;
            group.DeletedBy = userId;
            group.DeletedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }

        public static bool ValidateRepitedNames(List<Group> groups, int subjectId, string name, int groupId, bool isEdit)
        {
            if (isEdit)
            {
                foreach (var group in groups)
                {
                    if (group.Id != groupId)
                    {
                        if (group.SubjectId == subjectId)
                        {
                            if (group.Name == name)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var group in groups)
                {
                    if (group.SubjectId == subjectId)
                    {
                        if (group.Name == name)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static List<int> ValidateOverlappingSchedules(Classroom classroom, List<Session> sessions, int groupId, bool isEdit)
        {
            var Schedule = new int[13, 5]; //13 filas y 5 columnas
            var sessionsSchedule = new int[13, 5]; //13 filas y 5 columnas
            var result = new List<int>();
            //Llenar la matriz como vacia
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Schedule[i, j] = 0;
                    sessionsSchedule[i, j] = 0;
                }
            }
            //Llenar la matriz con los grupos
            //Si es edicion se llena sin el grupo que se edita
            if (isEdit)
            {

                foreach (var group in classroom.Groups)
                {
                    foreach (var session in group.Sessions)
                    {
                        if (group.Id != groupId)
                        {
                            var startHour = int.Parse(session.StartTime.ToString("hh"));
                            var endHour = int.Parse(session.EndTime.ToString("hh"));
                            var duration = endHour - startHour;

                            for (int i = 0; i < duration; i++)
                            {
                                var row = startHour - 7 + i;
                                var col = (int)session.Day;
                                Schedule[row, col] = group.Id;
                            }
                        }

                    }
                }
            }
            else
            {
                foreach (var group in classroom.Groups)
                {
                    foreach (var session in group.Sessions)
                    {

                        var startHour = int.Parse(session.StartTime.ToString("hh"));
                        var endHour = int.Parse(session.EndTime.ToString("hh"));
                        var duration = endHour - startHour;

                        for (int i = 0; i < duration; i++)
                        {
                            var row = startHour - 7 + i;
                            var col = (int)session.Day;
                            Schedule[row, col] = group.Id;
                        }


                    }
                }
            }
            //Llenar la matriz con el nuevo grupo
            foreach (var session in sessions)
            {
                var startHour = int.Parse(session.StartTime.ToString("hh"));
                var endHour = int.Parse(session.EndTime.ToString("hh"));
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
        public static bool ValidateNoThursday(List<Session> sessions)
        {
            foreach (var session in sessions)
            {
                if (session.Day == Day.Jueves && (session.StartTime.ToString("hh") == "11" || session.EndTime.ToString("hh") == "13")) 
                    return true;
            }
            return false;
        }

        
    }

}
