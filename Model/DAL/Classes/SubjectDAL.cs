using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL.Classes
{
    public class SubjectDAL : ISubjectDAL
    {
        readonly private ScheduleDbContext _context;

        public SubjectDAL(ScheduleDbContext context)
        {
            _context = context;
        }
        public DbSet<Subject> GetAll()
        {
            return _context.Subject;
        }
        public Task<Subject> GetForUpdate(int id)
        {
            return _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<Response> Add(Subject newSubject)
        {
            var response = new Response();
            var doesSubjectExists = await _context.Subject.AnyAsync(s => s.Code.ToLower() == newSubject.Code.ToLower());
            if(doesSubjectExists)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }

            if (newSubject.Alias == "") newSubject.Alias = null;
            newSubject.CreatedDate = DateTime.Now;
            _context.Add(newSubject);
            await _context.SaveChangesAsync();


            response.Ok = true;
            return response;

        }
        public async Task<Response> Update(Subject updatedSubject)
        {
            var response = new Response();
            var doesSubjectExists = await _context.Subject.AnyAsync(s => s.Code.ToLower() == updatedSubject.Code.ToLower() &&
                                                                         s.Id != updatedSubject.Id);
            if (doesSubjectExists)
            {
                response.Ok = false;
                response.ErrorType = 2;
                return response;
            }
            if (updatedSubject.Alias == "") updatedSubject.Alias = null;
            updatedSubject.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;
        }

        public async Task<bool> Delete(int subjectId, int userId)
        {
            var subject = await _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == subjectId);
            subject.DeletedBy = userId;
            subject.DeletedDate = DateTime.Now;
            subject.IsDeleted = true;
            var groups = await _context.Group.AsTracking().Where(g => g.SubjectId == subjectId).ToListAsync();
            foreach(var group in groups)
            {
                group.IsDeleted = true;
                group.DeletedBy = userId;
                group.DeletedDate = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
