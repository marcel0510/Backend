using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;


namespace Model.DAL.Classes
{
    public class BuildingDAL: IBuildingDAL
    {
        readonly private ScheduleDbContext _context;
        
        public BuildingDAL(ScheduleDbContext context)
        {
            _context = context;
        }
        public DbSet<Building> GetAll()
        {
            return _context.Building;
        }
        public Task<Building> GetForUpdate(int id)
        {
            return _context.Building.AsTracking().Include(b => b.Floors).FirstOrDefaultAsync(b => b.Id == id);

        }
        public async Task<Request> Add(Building newBuilding)
        {
            var request = new Request();
            var doesBuildExist = await _context.Building.AnyAsync(b => b.Code.ToLower() == newBuilding.Code.ToLower());
            if (doesBuildExist)
            {
                request.Ok = false;
                request.ErrorType = 1;
                return request;
            }

            newBuilding.CreatedDate = DateTime.Now;
            _context.Add(newBuilding);
            await _context.SaveChangesAsync();

            request.Ok = true;
            return request;

        }
        public async Task<Request> Update(Building updatedBuilding)
        {
            var request = new Request();
            var doesBuildExist = await _context.Building.AnyAsync(b => b.Code.ToLower() == updatedBuilding.Code.ToLower() && b.Id != updatedBuilding.Id);
            if (doesBuildExist)
            {
                request.Ok = false;
                request.ErrorType = 2;
                return request;
            }
            updatedBuilding.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            request.Ok = true;
            return request;

        }
        public async Task<bool> Delete(int buildingId, int userId)
        {
            var building = await _context.Building.AsTracking().FirstOrDefaultAsync(b => b.Id == buildingId);
            building.DeletedBy = userId;
            building.DeletedDate = DateTime.Now;
            building.IsDeleted = true;
            var Classrooms = await _context.Classroom.Where(c => c.BuildingId == buildingId).ToListAsync();
            foreach (var classroom in Classrooms)
            {
                classroom.IsDeleted = true;
                classroom.DeletedBy = userId;
                classroom.DeletedDate = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            return true;
        }

    
    }
}
