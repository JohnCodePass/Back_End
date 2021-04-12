using System.Collections.Generic;
using Back_End.Models;
using Back_End.Services.Context;
using System.Linq;
using Google.Apis.Sheets;


namespace Back_End.Services
{
    public class RoutesService
    {

        private readonly DataContext _datafromsql;
        
        public RoutesService(DataContext data)
        {
            _datafromsql = data;
        }

        public IEnumerable<Route> GetAllRoutes(){
            return  _datafromsql.RouteInfoSql;
        }

        public bool PostNewInfo(Route route)
        {
            _datafromsql.Add(route);
            _datafromsql.SaveChanges();
            return true;
        }
    }
}