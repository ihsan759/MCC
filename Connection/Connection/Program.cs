using Connection.Controllers;

namespace Connection;

public class Program
{
    public static void Main(string[] args)
    {
        MenuController menu = new MenuController();
        menu.Main();
    }
}