using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Context
{
    public class ShiftContext : IShiftContext
    {
        private HttpClient _client;

        public async Task<List<Shift>> GetAllUpcommingShfitsAsync(string autorization)
        {
            List<Shift> resultShifts = new List<Shift>();
            _client = new HttpClient();

            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", autorization);


            HttpResponseMessage res = await _client.GetAsync("https://localhost:44391/api/shift/getallupcommingshifts");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                resultShifts = JsonConvert.DeserializeObject<List<Shift>>(results);

            }

            return resultShifts;

        }

        public async Task<Shift> GetShiftAsync(string token, int shiftId)
        {
            Shift resultShift = new Shift();
            _client = new HttpClient();

            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


            HttpResponseMessage res = await _client.GetAsync("https://localhost:44391/api/shift/getshift/" + shiftId);
            if (res.IsSuccessStatusCode) 
            {
                var results = res.Content.ReadAsStringAsync().Result;
                resultShift = JsonConvert.DeserializeObject<Shift>(results);
            
            }

            return resultShift;
        }

        public async Task<List<Shift>> GetShiftForUserAsync(string autorization, int userId)
        {
                List<Shift> resultShifts = new List<Shift>();
                _client = new HttpClient();

                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", autorization);


            HttpResponseMessage res = await _client.GetAsync("https://localhost:44391/api/shift/getshiftsForUser/" + userId);
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    resultShifts = JsonConvert.DeserializeObject<List<Shift>>(results);

                }

                return resultShifts;
            
        }

    }
}
