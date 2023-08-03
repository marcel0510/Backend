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
        public Task<Subject> Get(int id)
        {
            return _context.Subject.AsTracking().FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<Request> Add(Subject newSubject)
        {
            var request = new Request();
            var doesSubjectExists = await _context.Subject.AnyAsync(s => s.Code.ToLower() == newSubject.Code.ToLower());
            if(doesSubjectExists)
            {
                request.Ok = false;
                request.ErrorType = 1;
                return request;
            }

            if (newSubject.Alias == "") newSubject.Alias = null;
            newSubject.CreatedDate = DateTime.Now;
            _context.Add(newSubject);
            await _context.SaveChangesAsync();


            request.Ok = true;
            return request;

        }
        public async Task<Request> Update(Subject updatedSubject)
        {
            var request = new Request();
            var doesSubjectExists = await _context.Subject.AnyAsync(s => s.Code.ToLower() == updatedSubject.Code.ToLower() &&
                                                                         s.Id != updatedSubject.Id);
            if (doesSubjectExists)
            {
                request.Ok = false;
                request.ErrorType = 2;
                return request;
            }
            if (updatedSubject.Alias == "") updatedSubject.Alias = null;
            updatedSubject.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            request.Ok = true;
            return request;
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
