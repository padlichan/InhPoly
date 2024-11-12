namespace Vehicles;

public abstract class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }
    public Engine EngineType { get; set; }

    protected Vehicle(string make, string model, Engine engineType)
    {
        Speed = 0;

        Make = make;
        Model = model;
        EngineType = engineType;
    }

    protected void StartEngine()
    {
        EngineType.Start();
    }

    public void Drive()
    {
        if (EngineType.IsRunning)
            Accelerate();
        else
            Console.WriteLine($"{Make} {Model} is not running.");
    }

    protected abstract void Accelerate();
}
