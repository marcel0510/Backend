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
       
        public async Task<Response> Add(User newUser)
        {
            var response = new Response();
            var doesUserExists = await _context.User.AnyAsync(u => u.Email == newUser.Email);
            if(doesUserExists)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }
            var doesRoleExists = await _context.User.AnyAsync(u => u.Role == newUser.Role);
            if(doesRoleExists)
            {
                response.Ok = false;
                response.ErrorType = 2;
                return response;
            }

            newUser.CreatedDate = DateTime.Now;
            _context.Add(newUser);
            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;
        }

        public async Task<Response> Update(User updatedUser)
        {
            var response = new Response();
            var doesUserExists = await _context.User.AnyAsync(u => u.Email.ToLower() == updatedUser.Email.ToLower() && u.Id != updatedUser.Id);
            if (doesUserExists)
            {
                response.Ok = false;
                response.ErrorType = 1;
                return response;
            }
            var doesRoleExists = await _context.User.AnyAsync(u => u.Role == updatedUser.Role && u.Id != updatedUser.Id);
            if (doesRoleExists)
            {
                response.Ok = false;
                response.ErrorType = 2;
                return response;
            }


            updatedUser.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();

            response.Ok = true;
            return response;
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

        public async Task<Response> ChangePassword(int id, string oldPassword, string newPassword)
        {
            var response = new Response();
            var user = await _context.User.AsTracking().FirstOrDefaultAsync(u => u.Id == id);   

            if (BCrypt.Net.BCrypt.Verify(oldPassword, user.Password))
            {
                if (BCrypt.Net.BCrypt.Verify(newPassword, user.Password))
                {
                    response.Ok = false;
                    response.ErrorType = 4;
                    return response;
                }

                user.Password = newPassword;
                await _context.SaveChangesAsync();
                response.Ok = true;
                return response;
            }
            else
            {
                response.Ok = false;
                response.ErrorType = 3;
                return response;
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

        public async Task<User> Validate(string email, string password)
        {
            var user = await _context.User.FirstOrDefaultAsync(u => u.Email == email);
            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return user;

            }
            return null;

        }
    }
}
