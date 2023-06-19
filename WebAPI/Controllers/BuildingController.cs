using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.AddDTO;
using WebAPI.DTO.DeleteDTO;
using WebAPI.DTO.EditDTO;
using WebAPI.DTO.ReadDTO.BuildingMapper;
using WebAPI.DTO.ReadDTO.ClassroomMapper;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/building/")]
    [ApiController]
    [Authorize]
    public class BuildingController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;
        private readonly IClassroomService _classroomService;

        public BuildingController(ScheduleDbContext context, IMapper mapper, IClassroomService classroomService)
        {
            _context = context;
            _mapper = mapper;
            _classroomService = classroomService;
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
        [AllowAnonymous]
        public async Task<ActionResult<BuildingDTO>> GetBuilding(int id)
        {
            if (_context.Building is null) { return Ok(new { isSuccess = false, typeError = 0 }); }
            var building = await _context.Building.FirstOrDefaultAsync(b => b.Id == id);
            var buildingDTO = _mapper.Map<BuildingDTO>(building);
            return buildingDTO;
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
                var buildingDB1 = await _context.Building.AsTracking().FirstOrDefaultAsync(b => b.Id == buildingDTO.Id);
                var isTheSame = buildingDTO.Code == buildingDB1.Code;
                if (isTheSame)
                {
                    buildingDB1 = _mapper.Map(buildingDTO, buildingDB1);
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
