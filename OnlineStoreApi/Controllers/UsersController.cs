using Microsoft.AspNetCore.Mvc;
using Online.Application.Services;
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


        [HttpGet]
        public List<User> GetAll() => _userService.GetAll();

        [HttpGet("{id}")]
        public User GetUser(int id) => _userService.GetUserById(id);

        [HttpPost]
        public User AddUser(User user) => _userService.AddUser(user);

        [HttpPut]
        public User UpdateUser(User user) => _userService.UpdateUser(user);

        [HttpDelete("{id}")]
        public User DeleteUser(int id) => _userService.DeleteUser(id);
    }
}

