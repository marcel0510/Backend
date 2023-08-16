using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.DAL.Interfaces
{
    public interface IGroupDAL
    {
        public DbSet<Group> GetAll();
        public Task<Group> GetForUpdate(int id);
        public Task<Response> Update(Group updatedGroup);
        public Task<Response> Add(Group newGroup);
        public Task<bool> Delete(int groupId, int userId);
    }
}
