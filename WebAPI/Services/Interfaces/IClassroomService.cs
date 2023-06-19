using Model;

namespace WebAPI.Services.Interfaces
{
    public interface IClassroomService
    {
        public Task<bool> DeleteClassroomByBuilding(ScheduleDbContext context, int buildingId, int userId);
    }
}
