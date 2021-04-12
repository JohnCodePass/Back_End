using System.Collections.Generic;
using Back_End.Models;
using System.Linq;
using Google.Apis.Sheets;

namespace Back_End.Services
{
    public class SheetsService
    {
        public List<Route> SheetsList = new List<Route>(){/* 
            new Route() {TypeOfDay = "Weekday", RouteNumber = 40, NumberOfStops = 7, Direction = "North",  Stops = new Stop[]{
                new Stop() {Location = "DTC Depart", NumberOfTimes = 55 , Times = new string[]{"1","2","3"}},
            }}
         */};
        public IEnumerable<Route> GetSheet(){
            return SheetsList;
        }
    }
}