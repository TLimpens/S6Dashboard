using Dashboard_backend.Managers.Context;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly IShiftContext _shiftContext;

        public ShiftRepository(IShiftContext shiftContext)
        {
            _shiftContext = shiftContext;
        }

        public async Task<List<Shift>> GetAllUpcommingShfitsAsync(string authorization)
        {
            return await _shiftContext.GetAllUpcommingShfitsAsync(authorization);
        }

        public async Task<Shift> GetShiftAsync(string token, int shiftId)
        {
            return await _shiftContext.GetShiftAsync(token, shiftId);
        }

        public async Task<List<Shift>> GetShiftForUserAsync(string authorization, int userId)
        {
            return await _shiftContext.GetShiftForUserAsync(authorization, userId);
        }
    }
}
