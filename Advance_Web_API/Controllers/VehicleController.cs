using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Advance_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        [HttpGet("{vehicleType:constraintEnum}")]
        public string GetVehicleByType(string vehicleType)
        {
            return "";
        }
    }
}