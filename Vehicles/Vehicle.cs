namespace Vehicles;

public abstract class Vehicle
{
    public string Make { get; }
    public string Model { get; }
    public int Speed { get; protected set; }
    public Engine EngineType { get; protected set; }

    protected Vehicle(string make, string model, Engine engineType)
    {
        Speed = 0;

        Make = make;
        Model = model;
        EngineType = engineType;
    }

    public void StartEngine()
    {
        EngineType.Start();
        Console.WriteLine("Vroom vroom!");
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
