namespace Project1_Authentication_
{
    internal class CRUD
    {
        protected List<User> users;
        Validation validation = new Validation();

        public CRUD()
        {
            users = new List<User>();
        }

        public CRUD(List<User> users)
        {
            this.users = users;
        }

        public void create()
        {
            Console.Write("First Name : ");
            string firstName = Console.ReadLine();
            while (!validation.Name(firstName))
            {
                Console.WriteLine("Nama minimum memiliki 2 karater");
                Console.Write("First Name : ");
                firstName = Console.ReadLine();
            }
            Console.Write("Last Name : ");
            string lastName = Console.ReadLine();
            while (!validation.Name(lastName))
            {
                Console.WriteLine("Nama minimum memiliki 2 karater");
                Console.Write("Last Name : ");
                lastName = Console.ReadLine();
            }
            Console.Write("Passoword : ");
            string password = Console.ReadLine();
            while (!validation.Password(password))
            {
                Console.WriteLine("Password minimum mengandung 1 huruf kecil, 1 huruf besar, 1 angka dan minimum 8 karakter");
                Console.Write("Password : ");
                password = Console.ReadLine();
            }

            string username = firstName.Substring(0, 2) + lastName.Substring(0, 2);
            int id = users.Count() + 1;
            User akun = new User(id, firstName, lastName, username, password, "Pengguna");
            users.Add(akun);
            Console.WriteLine("Data berhasil tersimpan");
            Console.WriteLine();
            Console.Write("Tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Read()
        {
            Console.WriteLine("=========Data User============");
            int id = 1;
            foreach (User user in users)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("ID \t : " + user.id);
                Console.WriteLine("Nama \t : " + user.firstName + " " + user.lastName);
                Console.WriteLine("Username : " + user.username);
                Console.WriteLine("Password : " + user.password);
                Console.WriteLine("Role \t : " + user.role);
                Console.WriteLine("==============================");
                id++;
            }
            if (id == 1)
            {
                Console.WriteLine("Data user kosong");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Edit User");
                Console.WriteLine("2. Delete User");
                Console.WriteLine("3. Kembali");
                Console.Write("Pilih : ");

                string pilih = "";
                pilih = Console.ReadLine();
                if (!validation.angka(pilih))
                {
                    Console.WriteLine("Hanya menerima inputan angka");
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    Read();
                }
                switch (pilih)
                {
                    case "1":
                        Update();
                        break;
                    case "2":
                        Delete();
                        break;
                    case "3":
                        try
                        {
                            Console.Clear();
                            return;
                        }
                        catch
                        {
                            Console.Clear();
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Pilihan anda tidak tersedia, silahkan coba kembali");
                        Console.WriteLine();
                        Console.Write("Tekan apapun untuk melanjutkan...");
                        Console.ReadKey();
                        Console.Clear();
                        Read();
                        break;
                }
            }
        }

        public void Delete()
        {
            Console.Write("Masukkan id yang ingin dihapus : ");
            string pilih = Console.ReadLine();
            if (validation.angka(pilih))
            {
                int id = int.Parse(pilih);
                if (Search(id))
                {
                    users.RemoveAt(id - 1);
                    for (int i = 0; i < users.Count; i++)
                    {
                        users[i].id = i + 1;
                    }
                    Console.WriteLine("Data berhasil dihapus");
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    Read();
                }
                else
                {
                    Console.WriteLine("Id tidak ditemukan, silahkan coba kembali");
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }

            }
            else
            {
                Console.WriteLine("Hanya menerima inputan angka");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }

        public void Update()
        {
            Console.Write("Silahkan masukkan id yang ingin di edit : ");
            string pilih = Console.ReadLine();
            if (!validation.angka(pilih))
            {
                Console.WriteLine("Hanya menerima inputan angka");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            int id = int.Parse(pilih);
            if (!Search(id))
            {
                Console.WriteLine("Id tidak ditemukan, silahkan coba kembali");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.Write("First Name : ");
            string firstName = Console.ReadLine();
            while (!validation.Name(firstName))
            {
                Console.WriteLine("Nama minimum memiliki 2 karater");
                Console.Write("First Name : ");
                firstName = Console.ReadLine();
            }
            Console.Write("Last Name : ");
            string lastName = Console.ReadLine();
            while (!validation.Name(lastName))
            {
                Console.WriteLine("Nama minimum memiliki 2 karater");
                Console.Write("Last Name : ");
                lastName = Console.ReadLine();
            }
            Console.Write("Passoword : ");
            string password = Console.ReadLine();
            while (!validation.Password(password))
            {
                Console.WriteLine("Password minimum mengandung 1 huruf kecil, 1 huruf besar, 1 angka dan minimum 8 karakter");
                Console.Write("Password : ");
                password = Console.ReadLine();
            }

            string username = firstName.Substring(0, 2) + lastName.Substring(0, 2);
            users[id - 1].firstName = firstName;
            users[id - 1].lastName = lastName;
            users[id - 1].username = username;
            users[id - 1].password = password;

            try
            {
                Console.WriteLine("Data berhasil diperbarui");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                Read();
            }
            catch
            {
                Console.WriteLine("Data gagal diperbarui");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                Read();
            }
        }

        public bool Search(int id)
        {
            User user = users.Find(u => u.id == id);
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public void Get()
        {
            Console.WriteLine("=========Cari Akun============");
            Console.Write("Masukkan Nama depan : ");
            string nama = Console.ReadLine();
            List<User> akun = users.FindAll(user => user.firstName.Contains(nama));
            int id = 1;
            foreach (var item in akun)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("ID \t : " + item.id);
                Console.WriteLine("Nama \t : " + item.firstName + " " + item.lastName);
                Console.WriteLine("Username : " + item.username);
                Console.WriteLine("Password : " + item.password);
                Console.WriteLine("==============================");
                id++;
            }
            if (id == 1)
            {
                Console.WriteLine("Data user kosong");
                Console.WriteLine();
                Console.Write("Masukkan nama belakang : ");
                nama = Console.ReadLine();
                List<User> akun2 = users.FindAll(user => user.lastName.Contains(nama));
                foreach (var item in akun)
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine("ID \t : " + item.id);
                    Console.WriteLine("Nama \t : " + item.firstName + " " + item.lastName);
                    Console.WriteLine("Username : " + item.username);
                    Console.WriteLine("Password : " + item.password);
                    Console.WriteLine("==============================");
                }
                Console.WriteLine("Data user kosong");
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine();
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
