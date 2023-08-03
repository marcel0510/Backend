using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL.Interfaces
{
    public interface IUserDAL
    {
        public DbSet<User> GetAll();
        public Task<User> GetById(int id);
        public Task<User> GetByEmail(string email);
        public Task<User> GetForUpdate(int id);
        public Task<Request> Add(User newUser);
        public Task<Request> Update(User updatedUser);
        public Task<bool> Delete(int ursId, int userId);
        public Task<Request> ChangePassword(int id, string oldPassword, string newPassword);
        public Task<bool> RestorePassword(int id, string newPassword, bool isRestored);
    }
}
