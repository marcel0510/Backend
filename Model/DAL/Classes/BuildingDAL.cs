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
        public async Task<Response> Add(Building newBuilding)
        {
            var response = new Response();
            var doesBuildExist = await _context.Building.AnyAsync(b => b.Code.ToLower() == newBuilding.Code.ToLower());
            if (doesBuildExist)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }

            newBuilding.CreatedDate = DateTime.Now;
            _context.Add(newBuilding);
            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;

        }
        public async Task<Response> Update(Building updatedBuilding)
        {
            var response = new Response();
            var doesBuildExist = await _context.Building.AnyAsync(b => b.Code.ToLower() == updatedBuilding.Code.ToLower() && b.Id != updatedBuilding.Id);
            if (doesBuildExist)
            {
                response.Ok = false;
                response.ErrorType = 2;
                return response;
            }

            updatedBuilding.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            response.Ok = true;
            return response;

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
