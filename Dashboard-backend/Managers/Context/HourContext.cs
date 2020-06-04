using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Context
{
    public class HourContext : IHourContext
    {
        private HttpClient _client;

        public async Task<int> getMontlyScheduledHoursForUser(string authorization, int userId)
        {
            _client = new HttpClient();

            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authorization);

            HttpResponseMessage res = await _client.GetAsync("https://localhost:44391/hours/getMontlyScheduledHoursForUser/userId");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<int>(results);

            }

            return -1;
        }

        public async Task<int> getMontlyWorkedHoursForUser(string authorization, int userId)
        {
            _client = new HttpClient();

            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authorization);

            HttpResponseMessage res = await _client.GetAsync("https://localhost:44391/hours/getMontlyWorkedHoursForUser/userId");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<int>(results);

            }

            return -1;
        }
    }
}
