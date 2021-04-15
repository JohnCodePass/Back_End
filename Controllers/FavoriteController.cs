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
    public class FavoriteController : ControllerBase
    {

        public IConfiguration Configuration { get; }

        private readonly FavoriteService _dataFromService;

        public FavoriteController(FavoriteService dataFromService, IConfiguration configuration)
        {
            _dataFromService = dataFromService;
            Configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<UserFavorite> GetAllFavorites()
        {
            return _dataFromService.GetAllFavorites();
        }

        [HttpPost, Route("add")]
        public bool Add(UserFavorite favorite)
        {
            return _dataFromService.addFavorite(favorite);
        }

        [HttpPut, Route("update")]
        public bool updateUser(UserFavorite favorite)
        {
            return _dataFromService.updateFavorite(favorite);
        }


        [HttpDelete, Route("delete")]
        public bool deleteUser(UserFavorite favorite)
        {
            return _dataFromService.deleteFavorite(favorite);
        }
    }
}