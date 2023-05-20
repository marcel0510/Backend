using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO;
using WebAPI.DTO.ClassroomMapper;

namespace WebAPI.Controllers
{
    [Route("api/building")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly IMapper _mapper;

        public BuildingController(ScheduleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildingDTO>>> GetBuildings()
        {
            if(_context.Building is null)
            {
                return NotFound();
            }
            return await _context.Building
                .ProjectTo<BuildingDTO>(_mapper.ConfigurationProvider).ToArrayAsync();

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BuildingDTO>> GetBuilding(int id)
        {
            if (_context.Building is null)
            {
                return NotFound();
            }
            var building = await _context.Building.FirstOrDefaultAsync(b => b.Id == id);
            var buildingDTO = _mapper.Map<BuildingDTO>(building);
            return buildingDTO;
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddBuilding(BuildingDTO buldingDTO)
        {
            var buildingDB = _mapper.Map<Building>(buldingDTO);
            _context.AddRange(buildingDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpPut("update/{id:int}")]
        public async Task<ActionResult> UpdateBuilding(int id, BuildingDTO buildingDTO)
        {
            var buildingDB = await _context.Building.AsTracking().FirstOrDefaultAsync(b => b.Id == id);
            if(buildingDB is null)
            {
                return NotFound();
            }
            buildingDB = _mapper.Map(buildingDTO, buildingDB);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> DeleteBuilding(int id)
        {
            var buildingDB = await _context.Building.AsTracking().FirstOrDefaultAsync(b => b.Id == id);
            if(buildingDB is null)
            {
                return NotFound();
            }
            buildingDB.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(true);
        }

    }
}
