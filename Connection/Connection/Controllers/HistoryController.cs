using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class HistoryController
    {
        private History _history = new History();
        private HistoryView _historyView = new HistoryView();
        public void GetAll()
        {
            _historyView.All(_history.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
