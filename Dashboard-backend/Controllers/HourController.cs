using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_backend.Controllers
{
        [Route("api/hours")]
        [ApiController]
        public class HourController : Controller
        {
            private readonly IHourRepository _hourRepository;

            public HourController(IHourRepository hourRepository)
            {
                _hourRepository = hourRepository;
            }

            [HttpGet]
            [Route("getMontlyWorkedHoursForUser/{userId}")]
            public Task<int> getMontlyWorkedHoursForUser([FromHeader]string authorization, int userId)
            {
                return _hourRepository.getMontlyWorkedHoursForUser(authorization, userId);
            }

            [HttpGet]
            [Route("getMontlyScheduledHoursForUser/{userId}")]
            public Task<int> getMontlyScheduledHoursForUser([FromHeader]string authorization, int userId)
            {
                return _hourRepository.getMontlyScheduledHoursForUser(authorization, userId);
            }
        }
    }
