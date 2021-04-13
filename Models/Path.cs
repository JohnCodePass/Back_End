namespace Back_End.Models
{
    public class Path
    {
        public int id { get; set; }
        public int routeNumber { get; set; }
        public string typeOfDay { get; set; }
        public string direction { get; set; }
        public string stopNames { get; set; }
        public string tripTimes { get; set; }

        public Path(){}

        public Path( int id, int routeNumber, string typeOfDay, string direction, string stopNames, string tripTimes)
        {
            this.id = id;
            this.routeNumber = routeNumber;
            this.typeOfDay = typeOfDay;
            this.direction = direction;
            this.tripTimes = tripTimes;
        }

    }
}