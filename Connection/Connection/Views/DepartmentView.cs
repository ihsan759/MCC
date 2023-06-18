using Connection.Models;

namespace Connection.Views
{
    public class DepartmentView
    {
        public void All(List<Department> departments)
        {
            foreach (Department department in departments)
            {
                Console.WriteLine("Id : " + department.Id);
                Console.WriteLine("Name : " + department.Name);
                Console.WriteLine("Department Location Id : " + department.LocarionId);
                Console.WriteLine("Department Manager Id : " + department.ManagerId);
                Console.WriteLine();
            }
        }
    }
}
