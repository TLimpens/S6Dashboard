using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Interfaces
{
    public interface IUserContext
    {
        Task<User> GetUser(int userId);

        List<List<User>> GetUsers();

        Task<User> GetUserResource(int userId);

        Task<List<User>> GetUserResources();
        Task<User> PostUserLogin(User user);

    }
}
