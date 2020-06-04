using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Context
{
    public class UserContext : IUserContext
    {
        private HttpClient _client;

        public Task<User> GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserResource(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUserResources()
        {
            throw new NotImplementedException();
        }

        public List<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> PostUserLogin([FromBody] User user)
        {
            User resultUser = new User();
            _client = new HttpClient();

            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage res = await _client.PostAsync("https://localhost:5020/api/account/login", data);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                resultUser = JsonConvert.DeserializeObject<User>(results);

            }

            return resultUser;
        }
    }
}
