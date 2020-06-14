using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Interfaces
{
    public interface IShiftContext
    {
        Task<Shift> GetShiftAsync(string token, int shiftId);
        Task<List<Shift>> GetShiftForUserAsync(string autorization, int userId);
        Task<List<Shift>> GetAllUpcommingShfitsAsync(string autorization);

    }
}
