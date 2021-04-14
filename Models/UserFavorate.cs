namespace Back_End.Models
{
    public class UserFavorate
    {
        public int id { get; set; }
        public string username { get; set; }
        public string destinationName { get; set; }
        public string destinationAddress { get; set; }
        public string savedStop { get; set;}

        public UserFavorate(int id, string username, string destinationName, string destinationAddress, string savedStop){
            this.id = id;
            this.username = username;
            this.destinationName = destinationName;
            this.destinationAddress = destinationAddress;
            this.savedStop = savedStop;
        }

        public UserFavorate() {}
    }
}
