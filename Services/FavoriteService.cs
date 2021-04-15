using System.Collections.Generic;
using Back_End.Models;
using System.Linq;
using Google.Apis.Sheets;
using Back_End.Context;


namespace Back_End.Services
{
    public class FavoriteService
    {
        private readonly Data _dataFromService;
        public FavoriteService(Data dataFromService)
        {
            _dataFromService = dataFromService;
        }


        public IEnumerable<UserFavorite> GetAllFavorites()
        {
            return _dataFromService.Favorites;
        }
    }
}