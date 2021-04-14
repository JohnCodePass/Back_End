using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End.Models;
using Back_End.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoutesController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        private readonly RoutesService _dataFromService;

        public RoutesController(RoutesService dataFromService,IConfiguration configuration)
        {
            _dataFromService = dataFromService;
            Configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Route> GetAllRoutes()
        {
            return _dataFromService.GetAllRoutes();
        }

        [HttpPost, Route("add")]
        public bool Add(Route route)
        {
            return _dataFromService.addRoute(route);
        }

        [HttpPost, Route("add-path")]
        public bool AddPath(Path path)
        {
            return _dataFromService.addPath(path);
        }
    }
}