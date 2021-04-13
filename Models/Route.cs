using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class Route
    {
        public int id { get; set; }
        public int number { get; set; }
        public string type { get; set; }

        public Route() { }

        public Route(int id, int number, string type)
        {
            this.id = id;
            this.number = number;
            this.type = type;
        }

    }
}