using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Model;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ScheduleDbContext _context;

        public GroupController(ScheduleDbContext context)
        {
            _context = context;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> Get()
        {
            if (_context.Group == null)
            {
                return NotFound();
            }

            return await _context.Group.ToArrayAsync();
        }
    }
}
