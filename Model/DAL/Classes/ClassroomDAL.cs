using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;

namespace Model.DAL.Classes
{
    public class ClassroomDAL : IClassroomDAL
    {
        readonly private ScheduleDbContext _context;

        public ClassroomDAL(ScheduleDbContext context)
        {
            _context = context;
        }
        public DbSet<Classroom> GetAll()
        {
            return _context.Classroom;
        }
       
        public Task<Classroom> GetForUpdate(int id)
        {
            return _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Response> Add(Classroom newClassroom)
        {
            var response = new Response();
            var doesClassroomExist = await _context.Classroom.AnyAsync(c => c.BuildingId == newClassroom.BuildingId &&
                                                                       c.Code.ToLower() == newClassroom.Code.ToLower() &&
                                                                       c.Floor.ToLower() == newClassroom.Floor.ToLower());
            if (doesClassroomExist)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }

            if (!newClassroom.IsLab) newClassroom.Name = null;
            newClassroom.CreatedDate = DateTime.Now;

            _context.Entry(newClassroom.Building).State = EntityState.Unchanged;
            _context.Add(newClassroom);
            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;

        }
        public async Task<Response> Update(Classroom updatedClassroom)
        {
            var response = new Response();
            var doesClassroomExist = await _context.Classroom.AnyAsync(c => c.BuildingId == updatedClassroom.BuildingId &&
                                                                       c.Code.ToLower() == updatedClassroom.Code.ToLower() &&
                                                                       c.Floor.ToLower() == updatedClassroom.Floor.ToLower() &&
                                                                       c.Id != updatedClassroom.Id);
            if (doesClassroomExist)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }

            if (!updatedClassroom.IsLab) updatedClassroom.Name = null;
            updatedClassroom.UpdatedDate = DateTime.Now;

            _context.Entry(updatedClassroom.Building).State = EntityState.Unchanged;
            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;
        }

        public async Task<bool> Delete(int classroomId, int userId)
        {
            var classroom = await _context.Classroom.AsTracking().FirstOrDefaultAsync(c => c.Id == classroomId);
            classroom.DeletedBy = userId;
            classroom.DeletedDate = DateTime.Now;
            classroom.IsDeleted = true;
            var groups = await _context.Group.AsTracking().Where(g => g.ClassroomId == classroomId).ToListAsync();
            foreach (var group in groups)
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
