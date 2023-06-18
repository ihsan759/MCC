using Connection.Models;

namespace Connection.Views
{
    public class RegionView
    {
        public void All(List<Region> regions)
        {
            foreach (Region region in regions)
            {
                Get(region);
            }
        }

        public void Get(Region region)
        {
            Console.WriteLine("Id : " + region.Id);
            Console.WriteLine("Name : " + region.Name);
            Console.WriteLine();
        }

        public void NotFound()
        {
            Console.WriteLine("Data kosong");
        }
    }
}
