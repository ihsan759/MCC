namespace Project1_Authentication_
{
    internal class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string role { get; set; }

        public User(int id, string firstName, string lastName, string username, string password, string role)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }
}
