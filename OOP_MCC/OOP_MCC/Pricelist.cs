namespace OOP_MCC
{
    public class Pricelist : Vehicle
    {
        public double price { get; set; }
        public Pricelist(double price, string name, string type, string color) : base(name, type, color)
        {
            //child class
            this.price = price;
        }

        public void PriceofVehicle(double discount)
        {
            base.Spesification();
            Console.WriteLine("Price : " + Total(discount));
        }

        public override void Spesification()
        {
            base.Spesification();
            Console.WriteLine("Price : " + Total());
        }
        public double Total()
        {
            double tax = 0.2d;
            return price * tax;
        }

        public double Total(double discount)
        {
            double tax = 0.2d;
            return price * tax * discount;
        }
    }
}
