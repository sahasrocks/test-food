using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using Project2.UserRepo;

namespace Project2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;
        public UsersController(IUserRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUserDetail()
        {
            return await _repository.GetUserDetail();

        }
        [HttpPost]
        public async Task<ActionResult<User>> PostUserDetail(User userdetails)
        {
            return await _repository.PostUserDetail(userdetails);
        }
        [HttpPut]
        public async Task<ActionResult<User>> PutUserDetail(User userdetails)
        {
            return await _repository.PutUserDetail(userdetails);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUserDetail(int id)
        {
            try
            {
                return await _repository.DeleteUserDetail(id);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}