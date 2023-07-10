using AutoMapper;
using Model;
using WebAPI.DTO.AddDTO.AddGroupMapper;
using WebAPI.DTO.ReadDTO.ClassroomMapper;
using WebAPI.DTO.ReadDTO.GroupMapper;

namespace WebAPI.Services.Interfaces
{
    public interface IGroupService
    {
        public Task<bool> DeleteGroupsByCalendar(ScheduleDbContext context, int calendarId, int userId);
        public Task<bool> DeleteGroupsBySubject(ScheduleDbContext context, int subjectId, int userId);
        public Task<bool> DeleteGroupsByClassroom(ScheduleDbContext context, int classroomId, int userId);
        public Task<bool> GenereteNewCalendar(ScheduleDbContext context, IMapper mapper, int IdOldCalendar, int IdNewCalendar, int userId);
        public bool ValidateRepitedNames(List<CGroupDTO> groups, int subjectId, string name);
        public List<int> ValidateOverlappingSchedules(ClassroomDTO classroom, List<AddSessionDTO> sessions, int groupId, bool isEdit);
    }
}
