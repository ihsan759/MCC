using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class CountryController
    {
        private Country _country = new Country();
        private CountryView _countryView = new CountryView();

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
            _countryView.All(_country.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Search()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string id = Console.ReadLine();
            var country = _country.Get(id);

            if (country == null)
            {
                _countryView.NotFound();
            }
            else
            {
                _countryView.Get(country);
            }

            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
        public void Insert()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string id = Console.ReadLine();
            Console.Write("Silahkan Masukkan Nama Country : ");
            string name = Console.ReadLine();
            bool FieldRegion = true;
            int regionId;
            do
            {
                Console.Write("Silahkan Masukkan Region Id : ");
                string region = Console.ReadLine();
                bool berhasil = int.TryParse(region, out regionId);
                if (berhasil)
                {
                    FieldRegion = false;
                }
                else
                {
                    Console.WriteLine("Harap memasukkan angka, silahkan coba kembali...");
                }
            } while (FieldRegion);
            int success = _country.Insert(id, name, regionId);
            if (success > 0)
            {
                Console.WriteLine("Berhasil Input Data");
            }
            else
            {
                Console.WriteLine("Gaal Input Data");
            }

            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Update()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string id = Console.ReadLine();
            Console.Write("Silahkan Masukkan Nama Country : ");
            string name = Console.ReadLine();
            bool FieldRegion = true;
            int regionId;
            do
            {
                Console.Write("Silahkan Masukkan Region Id : ");
                string region = Console.ReadLine();
                bool berhasil = int.TryParse(region, out regionId);
                if (berhasil)
                {
                    FieldRegion = false;
                }
                else
                {
                    Console.WriteLine("Harap memasukkan angka, silahkan coba kembali...");
                }
            } while (FieldRegion);
            int success = _country.Update(id, name, regionId);
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

        public void Delete()
        {
            Console.Write("Silahkan Masukkan ID : ");
            string id = Console.ReadLine();
            var country = _country.Delete(id);

            if (country > 0)
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
    }

}
