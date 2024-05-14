using System.Reflection;
using Tema11.CarData;
using Tema11.Interfaces;

namespace Tema11
{
    public class FuelingCar : Car
    {
        public string AutomobileType { get; private set; }

        public FuelingCar(string model, string automobileType, FuelType fuelType, double tankCapacity)
            : base(model, fuelType, tankCapacity)
        {
            AutomobileType = automobileType;
        }
        public void Refuel(double quantity)
        {
            string unit = FuelType == FuelType.Electricity ? "kWh" : "liters";
            Console.WriteLine($"Refueling {Model} with {quantity} {unit}.\n");
        }
    }
}