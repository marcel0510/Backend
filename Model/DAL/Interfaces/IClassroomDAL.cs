using Microsoft.EntityFrameworkCore;
using Model.Entities;


namespace Model.DAL.Interfaces
{
    public interface IClassroomDAL
    {
        public DbSet<Classroom> GetAll();
        public Task<Classroom> Get(int id);
        public Task<Request> Add(Classroom newClassroom);
        public Task<Request> Update(Classroom updatedClassroom);
        public Task<bool> Delete(int classroomId, int userId);
    }
}
