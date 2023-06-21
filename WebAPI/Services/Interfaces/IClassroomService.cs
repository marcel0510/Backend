using Model;
using WebAPI.DTO.AddDTO;

namespace WebAPI.Services.Interfaces
{
    public interface IClassroomService
    {
        public Task<bool> ValidateTheresNoRepit(ScheduleDbContext context, AddClassroomDTO classroomDTO, int buildingId);
        public Task<bool> DeleteClassroomByBuilding(ScheduleDbContext context, int buildingId, int userId);
    }
}
