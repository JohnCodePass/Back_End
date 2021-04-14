namespace Back_End.Models
{
    public class Path
    {
        public int id { get; set; }
        public int route { get; set; }
        public string typeOfRoute { get; set; }
        public string typeOfDay { get; set; }
        public string direction { get; set; }
        public string stops { get; set; }
        public string trips { get; set; }

        public Path(){}

        public Path( int id ,int route, string typeOfRoute, string typeOfDay, string direction, string stops, string trips)
        {
            this.id = id;
            this.route = route;
            this.typeOfRoute = typeOfRoute;
            this.typeOfDay = typeOfDay;
            this.direction = direction;
            this.stops = stops;
            this.trips = trips;
        }

    }
}