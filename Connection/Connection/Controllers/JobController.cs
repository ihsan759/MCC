using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class JobController
    {
        private Job _job = new Job();
        private JobView _jobView = new JobView();
        public void GetAll()
        {
            _jobView.All(_job.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
