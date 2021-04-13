namespace Back_End.Models
{
    public class Route
    {
        public int number {get;set;}
        public string type {get;set;}

        public Route() {}

        public Route(int number, string type)
        {
            this.number = number;
            this.type = type;
        }

    }
}