namespace Back_End.Models
{
    public class Stop
    {
        public int id { get;set; }
        public string stopName { get; set; }
        public string address { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }


            public Stop(int id, string stopName, string address, string latitude, string longitude){
            this.id = id;
            this.stopName = stopName;
            this.address = address;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}