using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Models;

namespace User.Application.Interfaces
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        Users GetUserByName(string userName);
        Users AddUser(Users user);
        Users UpdateUser(Guid id, string name);
    }
}

