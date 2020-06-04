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

        public Task<int> getMontlyScheduledHoursForUser(string authorization, int userId)
        {
            return _hourContext.getMontlyScheduledHoursForUser(authorization, userId);
        }

        public Task<int> getMontlyWorkedHoursForUser(string authorization, int userId)
        {
            return _hourContext.getMontlyWorkedHoursForUser(authorization, userId);
        }
    }
}
