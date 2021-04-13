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

        [HttpPost]
        public bool Add([FromBody] Route route)
        {

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString("myConnectionString")))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Route VALUES (@number, @type)");
                cmd.Parameters.AddWithValue("@number", route.number );
                cmd.Parameters.AddWithValue("@type", route.type );
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                return true;
            }

        }
    }
}