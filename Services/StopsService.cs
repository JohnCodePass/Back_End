using System.Collections.Generic;
using System.Linq;
using Back_End.Context;
using Back_End.Models;

namespace Back_End.Services
{
    public class StopsService
    {
        public readonly Data _Data;
        public StopsService(Data Data)
        {
            _Data = Data;
        }

        public IEnumerable<Stop> All()
        {
            return _Data.Stop;
        }

        public IEnumerable<Stop> WithId(int id)
        {
            return _Data.Stop.Where(s => s.stopId == id);
            // return new List<Stop>();
        }
        public bool Add(Stop stop)
        {
            _Data.Add(stop);
            int added = _Data.SaveChanges();
            return added > 0;

        }
    }
}