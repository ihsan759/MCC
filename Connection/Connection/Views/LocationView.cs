using Connection.Models;

namespace Connection.Views
{
    public class LocationView
    {
        public void All(List<Location> locations)
        {
            foreach (Location location in locations)
            {
                Console.WriteLine("Id : " + location.Id);
                Console.WriteLine("Street Address : " + location.StreetAddress);
                Console.WriteLine("Postal Code : " + location.PostalCode);
                Console.WriteLine("City : " + location.City);
                Console.WriteLine("State Province : " + location.StateProvince);
                Console.WriteLine("Country Id : " + location.CountryId);
                Console.WriteLine();
            }
        }
    }
}
