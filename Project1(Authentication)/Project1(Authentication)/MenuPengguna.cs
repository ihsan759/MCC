namespace Project1_Authentication_
{
    internal class MenuPengguna
    {
        public void menu(User akun, List<User> users)
        {
            Matematika matematika = new Matematika();
            Validation validation = new Validation();
            Console.WriteLine("===================================================");
            Console.WriteLine("\t\tMenu Ganjil Genap");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1. Cek Ganjil Genap");
            Console.WriteLine("2. Print Ganjil/Genap (dengan limit)");
            Console.WriteLine("3. Logout");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.Write("Pilihan: ");
            string pilihan = Console.ReadLine();
            switch (pilihan)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Masukkan Bilangan yang ingin di cek : ");
                    string bilangan = Console.ReadLine();
                    if (validation.angka(bilangan))
                    {
                        int angka = int.Parse(bilangan);
                        Console.WriteLine(matematika.EvenOddCheck(angka));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!!!");
                    }
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    menu(akun, users);
                    break;
                case "2":
                    Console.Write("Pilih (Ganjil/Genap) : ");
                    string pilih = Console.ReadLine();
                    Console.Write("Masukkan limit : ");
                    string limit = Console.ReadLine();
                    if (validation.angka(limit))
                    {
                        int number = int.Parse(limit);
                        matematika.PrintEvenOdd(number, pilih);
                    }
                    else
                    {
                        Console.WriteLine("Input limit tidak valid!!!");
                    }
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    menu(akun, users);
                    break;
                case "3":
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
