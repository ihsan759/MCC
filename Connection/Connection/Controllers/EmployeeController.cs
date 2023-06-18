using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class EmployeeController
    {
        private Employee _employee = new Employee();
        private EmployeeView _employeeView = new EmployeeView();
        public void GetAll()
        {
            _employeeView.All(_employee.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
