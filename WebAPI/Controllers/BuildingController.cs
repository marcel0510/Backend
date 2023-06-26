using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO.AddBuildingMapper;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.BuildingMapper;
using WebAPI.DTO.ReadDTO.SubjectMapper;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/building/")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly IClassroomService _classroomService;
        private readonly IBuildingService _buildingService;

        public BuildingController(ScheduleDbContext context, IMapper mapper, IClassroomService classroomService, IBuildingService buildingService)
        {
            _context = context;
            _mapper = mapper;
            _classroomService = classroomService;
            _buildingService = buildingService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<BuildingDTO>>> GetBuildings()
        {
            if(_context.Building is null) { return Ok(new { isSuccess = false, typeError = 0 }); }
            return await _context.Building
                .ProjectTo<BuildingDTO>(_mapper.ConfigurationProvider).ToArrayAsync();

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BuildingDTO>> GetBuilding(int id)
        {
 
            return await _context.Building
                    .ProjectTo<BuildingDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(b => b.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddBuilding(AddBuildingDTO buldingDTO)
        {
            var buildExists = await _context.Building.AnyAsync(b => b.Code.ToLower() == buldingDTO.Code.ToLower());
            if (buildExists) return Ok( new { isSuccess =  false, errorType = 1 });
            var buildingDB = _mapper.Map<Building>(buldingDTO);
            buildingDB.CreatedDate = DateTime.Now;
            _context.Add(buildingDB);
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateBuilding(EditBuildingDTO buildingDTO)
        {
            var buildExists = await _context.Building.AnyAsync(b => b.Code.ToLower() == buildingDTO.Code.ToLower());
            if (buildExists) {
                var buildingDB1 = await _context.Building.AsTracking().Include(b => b.Floors).FirstOrDefaultAsync(b => b.Id == buildingDTO.Id);
                var isTheSame = buildingDTO.Code == buildingDB1.Code;
                if (isTheSame)
                {
                    var updatedFloors = _mapper.Map<List<Floor>>(buildingDTO.Floors);
                    buildingDB1 = _mapper.Map(buildingDTO, buildingDB1);
                    buildingDB1.Floors.Clear();
                    buildingDB1.Floors = updatedFloors;
                    buildingDB1.UpdatedDate = DateTime.Now;
                    await _context.SaveChangesAsync();
                    return Ok(new { isSuccess = true });
                }
                else
                {
                    return Ok(new { isSuccess = false, errorType = 2 });
                }
            }
            var buildingDB2 = await _context.Building.AsTracking().FirstOrDefaultAsync(b => b.Id == buildingDTO.Id);
            buildingDB2 = _mapper.Map(buildingDTO, buildingDB2);
            buildingDB2.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }

        [HttpDelete("delete/{buildingId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteBuilding(int buildingId, int userId)
        {
            var buildingDB = await _context.Building.AsTracking().FirstOrDefaultAsync(b => b.Id == buildingId);
            if(buildingDB is null) { return Ok(new { isSuccess = false, typeError = 0 }); }
            buildingDB.DeletedBy = userId;
            buildingDB.DeletedDate = DateTime.Now;
            buildingDB.IsDeleted = true;
            var errasedClassrooms = await _classroomService.DeleteClassroomByBuilding(_context, buildingId, userId);
            if (!errasedClassrooms) return Ok(new { isSuccess = false, errorType = 3 });
            await _context.SaveChangesAsync();
            return Ok(new { isSuccess = true });
        }
 
    }
}
