using Model;

namespace WebAPI.Services.Interfaces
{
    public interface IBuildingService
    {
        public void AddFloors(ScheduleDbContext context, string[] floors, int buildingId);
    }
}
