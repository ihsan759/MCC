using Connection.Models;

namespace Connection.Views
{
    public class HistoryView
    {
        public void All(List<History> histories)
        {
            foreach (History history in histories)
            {
                Console.WriteLine("Start Date : " + history.StartDate);
                Console.WriteLine("Employee Id : " + history.EmployeeId);
                Console.WriteLine("End Date : " + history.EndDate);
                Console.WriteLine("Department Id : " + history.DepartmentId);
                Console.WriteLine("Job Id : " + history.JobId);
                Console.WriteLine();
            }
        }
    }
}
