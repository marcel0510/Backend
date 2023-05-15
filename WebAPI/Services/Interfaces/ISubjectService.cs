using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Services.Interfaces
{
    public interface ISubjectService
    {
        public Task<IEnumerable<dynamic>> GetSubjects();
        public Task<dynamic> GetSubject(int id);
    }
}
