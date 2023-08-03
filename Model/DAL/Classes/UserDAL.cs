using Microsoft.EntityFrameworkCore;
using Model.DAL.Interfaces;
using Model.Entities;
using Model.Enum;

namespace Model.DAL.Classes
{
    public class UserDAL : IUserDAL
    {
        readonly private ScheduleDbContext _context;

        public UserDAL(ScheduleDbContext context)
        {
            _context = context;
        }
        public DbSet<User> GetAll()
        {
            return _context.User;
        }
        public async Task<User> GetById(int id)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<User> GetByEmail(string email)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<User> GetForUpdate(int id)
        {
            return await _context.User.AsTracking().FirstOrDefaultAsync(u => u.Id == id);
        }
       
        public async Task<Request> Add(User newUser)
        {
            var request = new Request();
            var doesUserExists = await _context.User.AnyAsync(u => u.Email == newUser.Email);
            if(doesUserExists)
            {
                request.Ok = false;
                request.ErrorType = 1;
                return request;
            }
            var doesRoleExists = await _context.User.AnyAsync(u => u.Role == newUser.Role);
            if(doesRoleExists)
            {
                request.Ok = false;
                request.ErrorType = 2;
                return request;
            }

            newUser.CreatedDate = DateTime.Now;
            _context.Add(newUser);
            await _context.SaveChangesAsync();

            request.Ok = true;
            return request;
        }

        public async Task<Request> Update(User updatedUser)
        {
            var request = new Request();
            var doesUserExists = await _context.User.AnyAsync(u => u.Email.ToLower() == updatedUser.Email.ToLower() && u.Id != updatedUser.Id);
            if (doesUserExists)
            {
                request.Ok = false;
                request.ErrorType = 1;
                return request;
            }
            var doesRoleExists = await _context.User.AnyAsync(u => u.Role == updatedUser.Role && u.Id != updatedUser.Id);
            if (doesRoleExists)
            {
                request.Ok = false;
                request.ErrorType = 2;
                return request;
            }


            updatedUser.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();

            request.Ok = true;
            return request;
        }

        public async Task<bool> Delete(int usrId, int userId)
        {
            if (usrId == 1) return false;
            var user = await _context.User.AsTracking().FirstOrDefaultAsync(b => b.Id == usrId);
            user.IsDeleted = true;
            user.DeletedDate = DateTime.Now;
            user.DeletedBy = userId;
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<Request> ChangePassword(int id, string oldPassword, string newPassword)
        {
            var request = new Request();
            var user = await _context.User.AsTracking().FirstOrDefaultAsync(u => u.Id == id);   

            if (BCrypt.Net.BCrypt.Verify(oldPassword, user.Password))
            {
                if (BCrypt.Net.BCrypt.Verify(newPassword, user.Password))
                {
                    request.Ok = false;
                    request.ErrorType = 4;
                    return request;
                }

                user.Password = newPassword;
                await _context.SaveChangesAsync();
                request.Ok = true;
                return request;
            }
            else
            {
                request.Ok = false;
                request.ErrorType = 3;
                return request;
            }
        }

        public async Task<bool> RestorePassword(int id, string newPassword, bool isRestored)
        {
            var user = await _context.User.AsTracking().FirstOrDefaultAsync(u => u.Id == id);
            user.Password = newPassword;
            user.Reset = isRestored;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
