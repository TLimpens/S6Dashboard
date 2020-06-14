using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Interfaces
{
    public interface IHourContext
    {
        Task<int> getMontlyWorkedHoursForUserAsync(string authorization, int userId);
        Task<int> getMontlyScheduledHoursForUserAsync(string authorization, int userId);
    }
}
