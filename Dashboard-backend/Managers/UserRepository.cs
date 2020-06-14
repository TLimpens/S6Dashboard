using Dashboard_backend.Managers.Context;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserContext _userContext;

        public UserRepository(IUserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await _userContext.GetUserAsync(userId);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userContext.GetUsersAsync();
        }

        public async Task<User> PostUserLoginAsync(User user)
        {
            return await _userContext.PostUserLoginAsync(user);
        }
    }
}
