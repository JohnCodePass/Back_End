namespace Back_End.Models
{
    public class Fare
    {
        public int id { get; set; }
        public string riderType { get; set; }
        public string routeType { get; set; }
        public string type { get; set; }
        public string price { get; set; }

        public Fare() {}
        public Fare( int id, string riderType, string routeType, string type, string price)
        {
            this.id = id;
            this.riderType = riderType;
            this.routeType = routeType;
            this.type = type;
            this.price = price;
        }
    }
}