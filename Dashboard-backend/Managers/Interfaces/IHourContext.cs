using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Interfaces
{
    public interface IHourContext
    {
        Task<int> getMontlyWorkedHoursForUser(string authorization, int userId);
        Task<int> getMontlyScheduledHoursForUser(string authorization, int userId);
    }
}
