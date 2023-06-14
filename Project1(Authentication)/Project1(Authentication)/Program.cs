namespace Project1_Authentication_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<User> admin = new List<User>();
            admin.Add(new User(1, "Admin", "Pertama", "AdPe", "Admin1234", "Admin"));
            admin.Add(new User(2, "Pengguna", "Pertama", "PePe", "Pengguna1234", "Pengguna"));
            Auth auth = new Auth();
            auth.login(admin);
        }
    }
}