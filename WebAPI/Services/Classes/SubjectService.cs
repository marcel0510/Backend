using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services.Classes
{
    public class SubjectService : ISubjectService
    {
        private readonly ScheduleDbContext _context;

        public SubjectService(ScheduleDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<dynamic>>> GetSubjects()
        {

            var subjects = await _context.Subject.Select(s =>
            new
            {
                s.Id,
                s.Code,
                s.Name,
                s.NumHours,
                s.NumCredits,
                s.NumSemester,
                s.IsLab,
                Groups = s.Groups.Select(g => new {
                    g.Name,
                    Classroom = new
                    {
                        g.Classroom.Code,
                        g.Classroom.IsLab,
                        g.Classroom.Name,
                        g.Classroom.Capacity,
                        g.Classroom.Floor
                    },
                    Sessions = g.Sessions.Select(s => new
                    {
                        s.Day,
                        s.StartTime, 
                        s.EndTime
                    })
                }).ToList(),


            }).ToListAsync();

            return subjects; 

        }
    }
}
