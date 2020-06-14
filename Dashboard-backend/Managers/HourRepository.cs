using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers
{
    public class HourRepository : IHourRepository
    {

        private readonly IHourContext _hourContext;

        public HourRepository(IHourContext hourContext)
        {
            _hourContext = hourContext;
        }

        public async Task<int> getMontlyScheduledHoursForUserAsync(string authorization, int userId)
        {
            return await _hourContext.getMontlyScheduledHoursForUserAsync(authorization, userId);
        }

        public async Task<int> getMontlyWorkedHoursForUserAsync(string authorization, int userId)
        {
            return await _hourContext.getMontlyWorkedHoursForUserAsync(authorization, userId);
        }
    }
}
