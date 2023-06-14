internal class Implementsound : ISound
{
    public void VehicleSoundPlane(string name)
    {
        Console.WriteLine("Kendaraan ini " + name + "Bunyinya Bruuuummm..");
    }

    public void VehicleSoundCar(string name)
    {
        Console.WriteLine("Kendaraan ini " + name + "Bunyinya Ciiiittt...");
    }
}