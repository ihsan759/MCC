namespace Project1_Authentication_
{
    internal class MenuAdmin
    {
        public void menu(User akun, List<User> users)
        {
            CRUD cRUD = new CRUD(users);
            Console.WriteLine("======Menu Admin======");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Show User");
            Console.WriteLine("3. Search User");
            Console.WriteLine("4. Logout");
            Console.Write("Pilih : ");
            string pilih = Console.ReadLine();
            switch (pilih)
            {
                case "1":
                    Console.Clear();
                    cRUD.create();
                    menu(akun, users);
                    break;
                case "2":
                    Console.Clear();
                    cRUD.Read();
                    menu(akun, users);
                    break;
                case "3":
                    Console.Clear();
                    cRUD.Get();
                    menu(akun, users);
                    break;
                case "4":
                    Console.Clear();
                    Auth auth = new Auth();
                    auth.logout(users, akun);
                    break;
                default:
                    Console.WriteLine("Pilihan anda tidak tersedia silahkan coba kembali....");
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    menu(akun, users);
                    break;
            }
        }
    }
}
