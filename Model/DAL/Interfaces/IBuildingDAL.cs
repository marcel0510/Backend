using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.DAL.Interfaces
{
    public interface IBuildingDAL
    {
        public DbSet<Building> GetAll();
        public Task<Building> GetForUpdate(int id);
        public Task<Request> Add(Building newBuilding);
        public Task<Request> Update(Building updatedBuilding);
        public Task<bool> Delete(int buildingId, int userId);
    }
}
