using Microsoft.AspNetCore.Mvc;
using User.Application.Interfaces;
using User.Domain.Models;

namespace UserAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;


        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var userList = _userRepository.GetAllUsers();
            try
            {
                if (userList != null || userList.Count > 0)
                    return Ok(userList);
                else
                    return BadRequest("userList is empty");
            }
            catch (Exception ex)
            {
                return BadRequest("userList is empty");
            }

        }

        [HttpGet("GetUserByName")]
        public IActionResult GetUserByName(string user)
        {
            var getUser = _userRepository.GetUserByName(user);
            try
            {
                if (getUser != null)
                    return Ok(getUser);
                else
                    return BadRequest("user is empty");
            }
            catch (Exception ex)
            {
                return BadRequest("user is empty");
            }

        }
        [HttpGet("AddUser")]
        public IActionResult AddUser(Users user)
        {
            var addUser = _userRepository.AddUser(user);
            try
            {
                if (addUser != null)
                    return Ok(addUser);
                else
                    return BadRequest("Something went wrong");
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong");
            }

        }
        [HttpGet("UpdateUser")]
        public IActionResult UpdateUser(Guid id, string name)
        {
            var updateUser = _userRepository.UpdateUser(id, name);
            try
            {
                if (updateUser != null)
                    return Ok(updateUser);
                else
                    return BadRequest("Something went wrong");
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong");
            }

        }
    }
}
