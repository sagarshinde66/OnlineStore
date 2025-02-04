using Microsoft.AspNetCore.Mvc;
using OnlineStore.Application.Services;
using OnlineStore.Domain.Entites;

namespace OnlineStoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }


        [HttpGet("getall")]
        public List<User> GetAll() {
           return _userService.GetAll();
        }

        [HttpGet("get/{id}")]
        public User GetUser(int id) { 
            return _userService.GetUserById(id); 
        }

        [HttpPost("add")]
        public User AddUser(User user) {
            return _userService.AddUser(user); 
        }

        [HttpPut("update")]
        public User UpdateUser(User user)
        {
            return _userService.UpdateUser(user);
        }


        [HttpDelete("delete/{id}")]
        public User DeleteUser(int id) { 
            return _userService.DeleteUser(id); 
        }
    }
}

