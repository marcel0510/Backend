using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using WebAPI.Services.Classes;

namespace WebAPI.Controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ScheduleDbContext _context;
        private readonly SubjectService _service;

        public SubjectController(ScheduleDbContext context)
        {
            _context = context;
            _service = new (context);
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetSubjects()
        {
            if (_context.Subject == null)
            {
                return NotFound();
            }
            return await _service.GetSubjects();
            

             


       
        }
    }
}
