namespace Back_End.Models
{
    public class Route
    {
        public int RouteNumber{get;set;}
        public string TypeOfDay{get;set;}
        public int NumberOfStops{get;set;}
        public string Direction{get;set;}
        public Stop[] Stops{get;set;}

    }
}