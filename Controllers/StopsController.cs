using System.Collections.Generic;
using Back_End.Models;
using Back_End.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StopsController : ControllerBase
    {
        private readonly StopsService _Stops;
        public StopsController(StopsService stopsService)
        {
            _Stops = stopsService;
        }

        [HttpGet]
        public IEnumerable<Stop> Get([FromQuery] string id)
        {
            if (id != null)
            {
                bool isInt = Int32.TryParse(id, out int Id);
                if (isInt)
                {
                    return _Stops.WithId(Id);
                }
                else{
                    return _Stops.All();
                }
            }else{
                return _Stops.All();
            }
        }

        [HttpPost]
        public bool Add([FromBody] Stop stop)
        {
            return _Stops.Add(stop);
        }
    }
}