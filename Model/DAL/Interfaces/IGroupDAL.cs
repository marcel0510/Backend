using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.DAL.Interfaces
{
    public interface IGroupDAL
    {
        public DbSet<Group> GetAll();
        public Task<Group> Get(int id);
        public Task<Request> Add(Group newGroup);
        public Task<Request> Update(Group updatedGroup);
        public Task<bool> Delete(int groupId, int userId);
    }
}
