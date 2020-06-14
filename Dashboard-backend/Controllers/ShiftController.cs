using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_backend.Managers;
using Dashboard_backend.Managers.Context;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_backend.Controllers
{
    [Route("api/shifts")]
    [ApiController]
    public class ShiftController : Controller
    {
        private readonly IShiftRepository _shiftRepository;

        public ShiftController(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }

        [HttpGet]
        [Route("getallshifts")]
        public async Task<List<Shift>> GetAllUpcommingShifts([FromHeader]string authorization)
        {
            return await _shiftRepository.GetAllUpcommingShfitsAsync(authorization);
        }

        [HttpGet]
        [Route("getshift/{id}")]
        public async Task<Shift> GetShift([FromHeader]string authorization, int id)
        {
           return await _shiftRepository.GetShiftAsync(authorization, id);
        }

        [HttpGet]
        [Route("getshiftsforuser/{userId}")]
        public async Task<List<Shift>> GetShiftsForUser([FromHeader]string authorization, int userId)
        {
            return await _shiftRepository.GetShiftForUserAsync(authorization, userId);
        }
    }

}