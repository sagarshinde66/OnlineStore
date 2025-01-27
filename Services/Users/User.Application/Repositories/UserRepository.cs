using User.Application.Interfaces;
using User.Domain.Models;

namespace User.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        //user list static data 
        public static List<Users> users = new List<Users>()

        {
            new Users() { Id = Guid.NewGuid(), Name = "Abc", Email = "abc@gmail.com", IsActive = true },
            new Users() { Id = Guid.NewGuid(), Name = "xyz", Email = "xyz@gmail.com", IsActive = true },
            new Users() { Id = Guid.NewGuid(), Name = "sagar", Email = "sagar@gmail.com", IsActive = true },

        };

        public List<Users> GetAllUsers()
        {
            return users;
        }

        public Users GetUserByName(string userName)
        {
            //singkeordefault - sagar
            Users? user = new();
            try
            {
                user = users.Where(a => a.Name == userName).SingleOrDefault();

            }
            catch (Exception ex)
            {
                user = null;
            }
            return user;
        }

        public Users AddUser(Users user)
        {
            users.Add(user);
            return user;

        }

        public Users UpdateUser(Guid id, string name)
        {
            var updateUser = users.Where(a => a.Id == id).FirstOrDefault();
            updateUser.Name = name;
            return updateUser;
        }
    }
}
