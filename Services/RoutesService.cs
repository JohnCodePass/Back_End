using System.Collections.Generic;
using Back_End.Models;
using System.Linq;
using Google.Apis.Sheets;
using Back_End.Context;

namespace Back_End.Services
{
    public class RoutesService
    {
        private readonly Data _dataFromService;
        public RoutesService(Data dataFromService){
            _dataFromService = dataFromService;
        }
        public List<Route> RoutesList = new List<Route>(){/* 
            new Route() {TypeOfDay = "Weekday", RouteNumber = 40, NumberOfStops = 7, Direction = "North",  Stops = new Stop[]{
                new Stop() {Location = "DTC Depart", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
                new Stop() {Location = "Fremont & Commerce", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
                new Stop() {Location = "Pacific & Walnut", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
                new Stop() {Location = "Pacific & Knoles", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
                new Stop() {Location = "Pacific & Yokuts", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
                new Stop() {Location = "Pacific & Ben Holt", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
                new Stop() {Location = "HTS", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}}
            }}
         */};

        public IEnumerable<Route> GetAllRoutes(){
            return RoutesList;
        }

        public bool addRoute(Route route){
            _dataFromService.Add(route);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool addPath(Path path){
            _dataFromService.Add(path);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}