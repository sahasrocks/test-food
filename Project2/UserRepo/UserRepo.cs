using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Models;

namespace Project2.UserRepo
{
    public class UserRepo : IUserRepo
    {
        private readonly ProjectDbContext _context;
        public UserRepo(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<IEnumerable<User>>> GetUserDetail()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ActionResult<User>> PostUserDetail(User userdetail)
        {

            _context.Users.Add(userdetail);
            await _context.SaveChangesAsync();
            return userdetail;
        }
        public async Task<ActionResult<User>> PutUserDetail(User userdetail)
        {
            _context.Entry(userdetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userdetail;
        }
        public async Task<ActionResult<User>> DeleteUserDetail(int id)
        {
            var regUser = await _context.Users.FindAsync(id);
            if (regUser == null)
            {
                throw new NullReferenceException("Sorry no User found with this id");
            }
            else
            {
                _context.Users.Remove(regUser);
                await _context.SaveChangesAsync();
                return regUser;
            }
        }
    }
}
