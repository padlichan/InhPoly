namespace Vehicles;

internal class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(bool hasSideCar, string make, string model) : base(make, model, new MotorcycleEngine())
    {
        HasSidecar = hasSideCar;
    }

    protected override void Accelerate()
    {
        string message = $"{Make} {Model} speed: ";
        double fuelMod = EngineType.FuelType switch
        {
            FuelType.Unleaded => 1.5D,
            FuelType.Leaded => 1.2D,
            FuelType.Diesel => 1.8D,
            _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
        };
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{message}{((EngineType.HorsePower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (HasSidecar ? 0.8 : 1.0):F}mph");
        }
    }
}
