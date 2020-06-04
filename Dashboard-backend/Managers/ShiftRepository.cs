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

        public Task<Shift> GetShiftAsync(string token, int shiftId)
        {
            return _shiftContext.GetShiftAsync(token, shiftId);
        }

        public Task<List<Shift>> GetShiftForUserAsync(string authorization, int userId)
        {
            return _shiftContext.GetShiftForUserAsync(authorization, userId);
        }

        public List<Shift> GetShifts(User user)
        {
            throw new NotImplementedException();
        }
    }
}
