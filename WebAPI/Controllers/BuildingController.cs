using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using WebAPI.DTO.QueryDTO.BuildingMapper;
using Model.DAL.Interfaces;
using WebAPI.DTO.ManDTO;

namespace WebAPI.Controllers
{
    [Route("api/building/")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingDAL _buildingDAL;
        private readonly IMapper _mapper;

        public BuildingController(IBuildingDAL buildingDAL, IMapper mapper)
        {
            _buildingDAL = buildingDAL;
            _mapper = mapper;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<BuildingDTO>>> GetBuildings()
        {
            var Buildings = _buildingDAL.GetAll();
            return await Buildings.ProjectTo<BuildingDTO>(_mapper.ConfigurationProvider).ToArrayAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BuildingDTO>> GetBuilding(int id)
        {
            var Buildings = _buildingDAL.GetAll();
            return await Buildings.ProjectTo<BuildingDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(b => b.Id == id);
        }

        [HttpPost("new")]
        public async Task<ActionResult> AddBuilding(ManBuildingDTO buldingDTO)
        {
            var building = _mapper.Map<Building>(buldingDTO);
            var response = await _buildingDAL.Add(building);
            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateBuilding(ManBuildingDTO buildingDTO)
        {

            var building = await _buildingDAL.GetForUpdate((int)buildingDTO.Id);
            var updatedFloors = _mapper.Map<List<Floor>>(buildingDTO.Floors);
            building = _mapper.Map(buildingDTO, building);
            building.Floors.Clear();
            building.Floors = updatedFloors;

            var response = await _buildingDAL.Update(building);

            if (response.Ok) return Ok(new { isSuccess = true });
            else return Ok(new { isSuccess = false, errorType = response.ErrorType });
        }

        [HttpDelete("delete/{buildingId:int}/{userId:int}")]
        public async Task<ActionResult> DeleteBuilding(int buildingId, int userId)
        {
            var ok = await _buildingDAL.Delete(buildingId, userId);
            return Ok(new { isSuccess = ok });
        }
    }
}
