using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class RegionController
    {
        private Region _region = new Region();
        private RegionView _regionView = new RegionView();

        public void Menu()
        {
            bool isFinish = true;
            do
            {
                Console.WriteLine("+=================+");
                Console.WriteLine("|\tMenu\t  |");
                Console.WriteLine("+=================+");
                Console.WriteLine("|1. AllData\t  |");
                Console.WriteLine("|2. Search By Id  |");
                Console.WriteLine("|3. Insert Data\t  |");
                Console.WriteLine("|4. Update Data\t  |");
                Console.WriteLine("|5. Delete Data\t  |");
                Console.WriteLine("|6. Back\t  |");
                Console.WriteLine("+=================+");
                try
                {
                    Console.Write("Silahkan Pilih : ");
                    string? pilih = Console.ReadLine();
                    switch (pilih)
                    {
                        case "1":
                            Console.Clear();
                            GetAll();
                            break;
                        case "2":
                            Console.Clear();
                            Search();
                            break;
                        case "3":
                            Insert();
                            break;
                        case "4":
                            Update();
                            break;
                        case "5":
                            Delete();
                            break;
                        case "6":
                            isFinish = false;
                            break;
                        default:
                            Console.WriteLine("Pilihan anda tidak ditemukan....");
                            Console.Write("Silahkan Tekan apapun untuk melanjutkan....");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isFinish);
        }

        public void GetAll()
        {
            _regionView.All(_region.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Search()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string pilih = Console.ReadLine();
            int id;
            bool sukses = int.TryParse(pilih, out id);
            Region region;
            if (sukses)
            {
                region = _region.Get(id);
                if (region == null)
                {
                    _regionView.NotFound();
                }
                else
                {
                    _regionView.Get(region);
                }
                Console.Write("Silahkan tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hanya menerima inputan angka");
                Console.Write("Silahkan tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }




        }
        public void Insert()
        {
            Console.Write("Silahkan Masukkan Nama region : ");
            string name = Console.ReadLine();
            int success = _region.Insert(name);
            if (success > 0)
            {
                Console.WriteLine("Berhasil Input Data");
            }
            else
            {
                Console.WriteLine("Gagal Input Data");
            }

            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Update()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string pilih = Console.ReadLine();
            int id;
            bool sukses = int.TryParse(pilih, out id);
            if (sukses)
            {
                Console.Write("Silahkan Masukkan Nama region : ");
                string name = Console.ReadLine();
                int success = _region.Update(name, id);
                if (success > 0)
                {
                    Console.WriteLine("Berhasil Update Data");
                }
                else
                {
                    Console.WriteLine("Gaal Update Data");
                }

                Console.Write("Silahkan tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hanya Menerima inputan angka");
                Console.Write("Silahkan tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Delete()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string pilih = Console.ReadLine();
            int id;
            bool sukses = int.TryParse(pilih, out id);
            if (sukses)
            {
                var region = _region.Delete(id);

                if (region > 0)
                {
                    Console.WriteLine("Berhasil Hapus Data");
                }
                else
                {
                    Console.WriteLine("Gagal Hapus Data");
                }

                Console.Write("Silahkan tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hanya Menerima Inputan Angka");
                Console.Write("Silahkan tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
