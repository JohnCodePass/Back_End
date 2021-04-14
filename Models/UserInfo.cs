namespace Back_End.Models
{
    public class UserInfo
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public UserInfo(int id, string username, string password, string email){
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public UserInfo() {}
    }
}