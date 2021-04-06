using System.Collections.Generic;
using Back_End.Models;
using System.Linq;


namespace Back_End.Services
{
    public class RoutesService
    {
        public List<RouteModel> RoutesList = new List<RoutesModel>(){
            
        };

        public IEnumerable<RoutesModel> GetAllRoutes(){
            return RoutesList;
        }
    }
}