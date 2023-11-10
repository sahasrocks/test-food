using Microsoft.AspNetCore.Mvc;
using Project2.Models;

namespace Project2.UserRepo
{
    public interface IUserRepo
    {
        Task<ActionResult<IEnumerable<User>>> GetUserDetail();
        Task<ActionResult<User>> PostUserDetail(User userdetail);
        Task<ActionResult<User>> PutUserDetail(User userdetail);
        Task<ActionResult<User>> DeleteUserDetail(int id);
    }
}
