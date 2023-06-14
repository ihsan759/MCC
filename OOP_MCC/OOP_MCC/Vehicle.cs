public class Vehicle
{
    public string name { get; set; }
    public string type { get; set; }
    public string color { get; set; }

    public Vehicle(string name, string type, string color)
    {
        this.name = name;
        this.type = type;
        this.color = color;
    }

    public virtual void Spesification()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Type : " + type);
        Console.WriteLine("Color : " + color);
    }

}