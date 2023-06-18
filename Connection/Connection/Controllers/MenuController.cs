namespace Connection.Controllers
{
    public class MenuController
    {
        public void Main()
        {
            bool isFinish = true;
            do
            {
                Console.WriteLine("+=================+");
                Console.WriteLine("|\tMenu\t  |");
                Console.WriteLine("+=================+");
                Console.WriteLine("|1. Country\t  |");
                Console.WriteLine("|2. Department\t  |");
                Console.WriteLine("|3. Employee\t  |");
                Console.WriteLine("|4. History\t  |");
                Console.WriteLine("|5. Job\t\t  |");
                Console.WriteLine("|6. Location\t  |");
                Console.WriteLine("|7. Region\t  |");
                Console.WriteLine("|8. Exit\t  |");
                Console.WriteLine("+=================+");
                try
                {
                    Console.Write("Silahkan Pilih : ");
                    string pilih = Console.ReadLine();
                    switch (pilih)
                    {
                        case "1":
                            Console.Clear();
                            CountryController countryController = new CountryController();
                            countryController.Menu();
                            Console.Clear();
                            break;
                        case "2":
                            Console.Clear();
                            DepartmentController departmentController = new DepartmentController();
                            departmentController.GetAll();
                            Console.Clear();
                            break;
                        case "3":
                            Console.Clear();
                            EmployeeController employeeController = new EmployeeController();
                            employeeController.GetAll();
                            Console.Clear();
                            break;
                        case "4":
                            Console.Clear();
                            HistoryController historyController = new HistoryController();
                            historyController.GetAll();
                            Console.Clear();
                            break;
                        case "5":
                            Console.Clear();
                            JobController jobController = new JobController();
                            jobController.GetAll();
                            Console.Clear();
                            break;
                        case "6":
                            Console.Clear();
                            LocationController locationController = new LocationController();
                            locationController.GetAll();
                            Console.Clear();
                            break;
                        case "7":
                            Console.Clear();
                            RegionController regionController = new RegionController();
                            regionController.Menu();
                            Console.Clear();
                            break;
                        case "8":
                            Console.WriteLine("Selamat tinggal....:D");
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
    }
}
