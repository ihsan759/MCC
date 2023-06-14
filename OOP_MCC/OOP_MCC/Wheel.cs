public class Wheel : Vehicle, ISound
{
    public int wheel;

    public Wheel(int wheel, string name, string type, string color) : base(name, type, color)
    {
        //parent class
        this.name = name;
        this.type = type;
        this.color = color;

        //Child Class
        this.wheel = wheel;
    }

    public override void Spesification()
    {
        base.Spesification();
        Console.WriteLine("wheel : " + wheel);
    }

    public void VehicleSoundPlane(string name)
    {
        Console.WriteLine("Kendaraan ini " + name + " Bunyinya Bruuuummm..");
    }

    public void VehicleSoundCar(string name)
    {
        Console.WriteLine("Kendaraan ini " + name + " Bunyinya Ciiittt..");
    }

    internal void VehicleSoundPlane()
    {
        throw new NotImplementedException();
    }
}