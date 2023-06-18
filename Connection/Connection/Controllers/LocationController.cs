using Connection.Models;
using Connection.Views;

namespace Connection.Controllers
{
    public class LocationController
    {
        private Location _location = new Location();
        private LocationView _locationView = new LocationView();

        public void GetAll()
        {
            _locationView.All(_location.GetAll());
            Console.Write("Silahkan tekan apapun untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
