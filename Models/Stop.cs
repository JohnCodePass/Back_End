namespace Back_End.Models
{
    public class Stop
    {
        public int id { get;set; }
        public int stopId { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }


            public Stop(int id, int stopId, string name, double lat, double lon){
            this.id = id;
            this.stopId = stopId;
            this.name = name;
            this.lat = lat;
            this.lon = lon;
        }
            public Stop() {}
    }
}