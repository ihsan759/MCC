namespace Latihan1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> num = new Dictionary<int, string>();
            num.Add(1, "One");
            num.Add(2, "Two");
            num.Add(5, "Five");
            num.Add(4, "Four");

            foreach (var item in num)
            {
                Console.WriteLine("Key : {0}, value : {1}", item.Key, item.Value);
            }
        }
    }
}