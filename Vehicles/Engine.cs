namespace Vehicles
{
    public abstract class Engine
    {
        public bool IsRunning { get; set; }
        public int HorsePower {  get; set; }
        public FuelType FuelType { get; set; }

        protected Engine(int horsePower, FuelType fuelType)
        {
            IsRunning = false;
            HorsePower = horsePower;
            FuelType = fuelType;
        }
    }
}
