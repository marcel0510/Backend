using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Services.Interfaces;
using Model;

namespace WebAPI.Services.Classes
{
    public class SubjectService : ISubjectService
    {
        private readonly ScheduleDbContext _context;

        public SubjectService(ScheduleDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<dynamic>> GetSubjects()
        {

            var subjects = await _context.Subject
                .Select(s => new
                {
                    s.Code,
                    s.Name,
                    s.NumHours,
                    s.NumCredits,
                    s.NumSemester,
                    s.IsLab
                })
                .ToListAsync();
            
            return subjects;
        }

        public async Task<dynamic> GetSubject(int id) {         
            var subject = await _context.Subject
                .Select(s => new
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
                            g.Classroom.Floor,
                            buildCode = g.Classroom.Building.Code,
                            buildName = g.Classroom.Building.Name,
                           
                        },
                        Sessions = g.Sessions.Select(s => new
                        {
                            s.Day,
                            s.StartTime,
                            s.EndTime
                        })
                    }).ToList(),
                }).FirstOrDefaultAsync(s => s.Id == id);

            return subject;
        }
    }
}
