namespace Vehicles;

public class Car : Vehicle
{
    public Car(string make, string model) : base(make, model, new CarEngine())
    {
    }
}
