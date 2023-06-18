using Connection.Models;

namespace Connection.Views
{
    public class JobView
    {
        public void All(List<Job> jobs)
        {
            foreach (Job job in jobs)
            {
                Console.WriteLine("Id : " + job.Id);
                Console.WriteLine("Title : " + job.Title);
                Console.WriteLine("Min Salary : " + job.MinSalary);
                Console.WriteLine("Max Salary : " + job.MaxSalary);
                Console.WriteLine();
            }
        }
    }
}
