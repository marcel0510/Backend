using Model;
using Model.Entities;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services.Classes
{
    public class BuildingService : IBuildingService
    {
        public void AddFloors(ScheduleDbContext context, string[] floors, int buildingId)
        {
            foreach(var floor in floors)
            {
                var floorDB = new Floor() {
                    Code = floor,
                    BuildingId = buildingId,
                };
                context.Floors.Add(floorDB);
            }
        }
    }
}
