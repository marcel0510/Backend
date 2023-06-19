using Microsoft.EntityFrameworkCore;
using Model;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services.Classes
{
    public class ClassroomService : IClassroomService
    {
        public async Task<bool> DeleteClassroomByBuilding(ScheduleDbContext context, int buildingId, int userId)
        {
            var classroomsDB = await context.Classroom.AsTracking().Where(c => c.BuildingId == buildingId).ToListAsync();
            if(classroomsDB == null) return false;
            classroomsDB.ForEach(c =>
            {
                c.IsDeleted = true;
                c.DeletedBy = userId;
                c.DeletedDate = DateTime.Now;
            });

            return true;
        }
    }
}
