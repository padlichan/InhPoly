namespace Vehicles;

internal class Program
{
    static void Main(string[] args)
    {
        Car chrisCar = new Car("Ford", "Mustang");
        Motorcycle liliBike = new Motorcycle(false,"Suzuki","Avenis");

        chrisCar.Drive();

        chrisCar.StartEngine();
        liliBike.StartEngine();

        chrisCar.Drive();
        liliBike.Drive();
    }
}
