using OnlineStore.Domain.Entites;
using OnlineStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Application.Services
{
    public class UserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll() { 
            return _userRepository.GetAll(); 
        } 
        public User GetUserById(int id) { 
            return _userRepository.GetById(id); 
        }
        public User AddUser(User user) { 
            return _userRepository.Add(user); 
        }
        public User UpdateUser(User user) { 
            return _userRepository.Update(user); 
        }
        public User DeleteUser(int id) { 
            return _userRepository.Delete(id);
        } 
    }
}
