using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class DepartmentController
    {
        private Department _department = new Department();
        private DepartmentView _departmentView = new DepartmentView();
        public void GetAll()
        {
            _departmentView.All(_department.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
