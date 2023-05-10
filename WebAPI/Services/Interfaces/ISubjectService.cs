using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Models;

namespace WebAPI.Services.Interfaces
{
    public interface ISubjectService
    {
        public Task<ActionResult<IEnumerable<dynamic>>> GetSubjects();
    }
}
