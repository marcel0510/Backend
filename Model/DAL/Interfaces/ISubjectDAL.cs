using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL.Interfaces
{
    public interface ISubjectDAL
    {
        public DbSet<Subject> GetAll();
        public Task<Subject> Get(int id);
        public Task<Request> Add(Subject newSubject);
        public Task<Request> Update(Subject updatedSubject);
        public Task<bool> Delete(int subjectId, int userId);
    }
}
