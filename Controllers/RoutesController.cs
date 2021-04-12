using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End.Models;
using Back_End.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoutesController : ControllerBase
    {

        private readonly RoutesService _dataFromService;

        public RoutesController(RoutesService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet]
        public IEnumerable<Route> GetAllRoutes()
        {
            return _dataFromService.GetAllRoutes();
        }

        [HttpPost("add")]
        public bool PostNewInfo(Route route)
        {
            return _dataFromService.PostNewInfo(route);
        }
    }
}