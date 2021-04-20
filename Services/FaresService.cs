using System.Collections.Generic;
using Back_End.Models;
using System.Linq;
using Google.Apis.Sheets;
using Back_End.Context;

namespace Back_End.Services
{
    public class FaresService
    {
        private readonly Data _dataFromService;
        public FaresService(Data dataFromService)
        {
            _dataFromService = dataFromService;
        }

        public IEnumerable<Fare> GetAllFares(string type){
            if(type == null)
            {
            return _dataFromService.Fares;
            }
            else{
                return _dataFromService.Fares.Where(f => f.routeType == type);
            }
        }

        public bool AddFare(Fare fare)
        {
            _dataFromService.Add(fare);
            _dataFromService.SaveChanges();
            return true;
        }
        
    }
}