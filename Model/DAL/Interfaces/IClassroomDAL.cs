using Microsoft.EntityFrameworkCore;
using Model.Entities;


namespace Model.DAL.Interfaces
{
    public interface IClassroomDAL
    {
        public DbSet<Classroom> GetAll();
        public Task<Classroom> GetForUpdate(int id);
        public Task<Response> Update(Classroom updatedClassroom);
        public Task<Response> Add(Classroom newClassroom);
        public Task<bool> Delete(int classroomId, int userId);
    }
}
