using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_backend.Managers;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_backend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("getUsers")]
        public Task<List<User>> GetUserS()
        {
            return _userRepository.GetUsers();
        }

        [HttpGet]
        [Route("getUser/{id}")]
        public Task<User> GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        [HttpPost]
        [Route("postUserLogin")]
        public Task<User> PostUserLogin([FromBody] User user)
        {
            return _userRepository.PostUserLogin(user);
        }
    }
}
