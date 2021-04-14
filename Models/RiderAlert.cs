namespace Back_End.Models
{
    public class RiderAlert
    {
        public int id { get;set; }
        public string date { get; set; }
        public string title { get; set; }
        public string content { get; set; }


            public RiderAlert(int id, string date, string title, string content){
            this.id = id;
            this.date = date;
            this.title = title;
            this.content = content;
        }
    }
}