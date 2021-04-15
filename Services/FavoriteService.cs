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

        public bool addFavorite(UserFavorite favorite)
        {
            _dataFromService.Add(favorite);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateFavorite(UserFavorite favorite){
            _dataFromService.Favorites.Update(favorite);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteFavorite(UserFavorite favorite)
        {
            _dataFromService.Favorites.Remove(favorite);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}