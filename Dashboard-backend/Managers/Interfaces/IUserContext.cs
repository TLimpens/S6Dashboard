using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Interfaces
{
    public interface IUserContext
    {
        Task<User> GetUserAsync(int userId);
        Task<List<User>> GetUsersAsync();
        Task<User> PostUserLoginAsync(User user);

    }
}
