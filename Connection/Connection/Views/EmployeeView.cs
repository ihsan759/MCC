using Connection.Models;

namespace Connection.Views
{
    public class EmployeeView
    {
        public void All(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Id : " + employee.Id);
                Console.WriteLine("Name : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Email : " + employee.Email);
                Console.WriteLine("Phone Number : " + employee.PhoneNumber);
                Console.WriteLine("Hire Date : " + employee.HireDate);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Comission Pct : " + employee.ComissionPct);
                Console.WriteLine("Manager Id : " + employee.ManagerId);
                Console.WriteLine("Job Id : " + employee.JobId);
                Console.WriteLine("DepartmentId : " + employee.DepartmentId);
                Console.WriteLine();
            }
        }
    }
}
