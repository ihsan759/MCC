namespace Project1_Authentication_
{
    internal class Auth
    {
        Validation validation = new Validation();

        public void login(List<User> users)
        {
            Console.WriteLine("=========Login Akun===========");
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password : ");
            string password = Console.ReadLine();
            User akun = users.FirstOrDefault(user => user.username.Contains(username) && user.password.Contains(password));
            if (akun != null)
            {
                Console.WriteLine("Selamat datang : " + akun.firstName + " " + akun.lastName);
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                if (validation.role(akun.role))
                {
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.menu(akun, users);
                }
                else
                {
                    MenuPengguna menuPengguna = new MenuPengguna();
                    menuPengguna.menu(akun, users);
                }
            }
            else
            {
                Console.WriteLine("Username atau password salah");
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                login(users);
            }
        }

        public void logout(List<User> users, User user)
        {
            Console.WriteLine("Selamat tinggal " + user.firstName + " " + user.lastName);
            Console.Write("Tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
            login(users);
        }

    }
}
