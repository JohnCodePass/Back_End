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
        public RoutesService(Data dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<Route> GetAllRoutes(string type)
        {
            if(type == null){
            return _dataFromService.Routes;
            }
            else{
                return _dataFromService.Routes.Where(r => r.type == type);
            }
        }

        public bool addRoute(Route route)
        {
            _dataFromService.Add(route);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool addPath(Path path)
        {
            _dataFromService.Add(path);
            _dataFromService.SaveChanges();
            return true;
        }

        public IEnumerable<Path> getAllPaths(string type)
        {
            return type != null ? _dataFromService.Paths.Where( p => p.typeOfRoute == type) :
            _dataFromService.Paths;
        }

        public bool updatePath(Path path){
            _dataFromService.Paths.Update(path);
            _dataFromService.SaveChanges();
            return true;
        }

    }
}