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
    public class FaresController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        private readonly FaresService _dataFromService;

        public FaresController(FaresService dataFromService, IConfiguration configuration)
        {
            _dataFromService = dataFromService;
            Configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Fare> GetAllFares(string type)
        {
            return _dataFromService.GetAllFares(type);
        }

        [HttpPost]
        public bool AddFare([FromBody] Fare fare)
        {
            return _dataFromService.AddFare(fare);
        }

    }
}