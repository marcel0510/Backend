using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;
using WebAPI.DTO.ManDTO;
using WebAPI.DTO.QueryDTO.ClassroomMapper;

namespace WebAPI.Controllers
{
    [Route("api/classroom")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomDAL _classroomDAL;
        private readonly IMapper _mapper;

        public ClassroomController(IClassroomDAL classroomDAL, IMapper mapper)
        {
            _classroomDAL = classroomDAL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralClassroomDTO>>> GetClassrooms()
        {
            var Classrooms = _classroomDAL.GetAll();
            return await Classrooms.ProjectTo<GeneralClassroomDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
        [HttpGet("byCalendar/{calendarId:int}")]
        public async Task<ActionResult<IEnumerable<ClassroomDTO>>> GetClassroomsByCalendar(int calendarId)
        {
            var Classrooms = _classroomDAL.GetAll();
            var ClassroomsDTO = await Classrooms .ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).ToArrayAsync();
            var filteredClassrooms = new List<ClassroomDTO>();

            foreach (var classroom in ClassroomsDTO)
            {
                var filteredGroups = classroom.Groups.Where(g => g.CalendarId == calendarId).ToList();
                var filteredClassroom = new ClassroomDTO()
                {
                    Id = classroom.Id,
                    Code = classroom.Code,
                    IsLab = classroom.IsLab,
                    Name = classroom.Name,
                    Capacity = classroom.Capacity,
                    Floor = classroom.Floor,
                    Building = classroom.Building,
                    Groups = filteredGroups
                };
                filteredClassrooms.Add(filteredClassroom);
            }
            return filteredClassrooms;
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClassroomDTO>> GetClassroom(int id)
        {
            var Classrooms = _classroomDAL.GetAll();
            return await Classrooms.ProjectTo<ClassroomDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddClasroom(ManClassroomDTO classroomDTO)
        {
            var classroom = _mapper.Map<Classroom>(classroomDTO);
            var response = await _classroomDAL.Add(classroom);
            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateClassroom(ManClassroomDTO classroomDTO)
        {

            var classroom = await _classroomDAL.GetForUpdate((int)classroomDTO.Id);
            classroom = _mapper.Map(classroomDTO, classroom);
            var response = await _classroomDAL.Update(classroom);
            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }
       
        [HttpDelete("delete/{classroomId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteClassroom(int classroomId, int userId)
        {
            var ok = await _classroomDAL.Delete(classroomId, userId);
            return Ok(new { isSuccess = ok });
        }
    }
}
