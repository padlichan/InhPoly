namespace Vehicles;

internal class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }

    public Motorcycle(bool hasSideCar, string make, string model) : base(make, model, new MotorcycleEngine())
    {
        HasSideCar = hasSideCar;
    }  
}
