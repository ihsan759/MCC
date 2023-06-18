using Connection.Models;

namespace Connection.Views
{
    public class CountryView
    {
        public void All(List<Country> countries)
        {
            foreach (Country country in countries)
            {
                Get(country);
            }
        }

        public void Get(Country country)
        {
            Console.WriteLine("Id : " + country.Id);
            Console.WriteLine("Name : " + country.Name);
            Console.WriteLine("Region Id : " + country.RegionId);
            Console.WriteLine();
        }

        public void NotFound()
        {
            Console.WriteLine("Data kosong");
        }
    }
}
