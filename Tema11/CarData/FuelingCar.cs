using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema11.Interfaces;


namespace Tema11.CarData
{
    public class FuelingCar : Car
    {
        public string AutomobileType { get; private set; }
        public FuelingCar(string model, string automobileType, FuelType fuelType, double tankCapacity)
     : base(model, fuelType, tankCapacity)
        {
            if (automobileType == "Gas" && fuelType != FuelType.Gas ||
                automobileType == "Diesel" && fuelType != FuelType.Diesel ||
                automobileType == "LPG" && fuelType != FuelType.LPG ||
                (automobileType == "Hybrid" && (fuelType != FuelType.Gas && fuelType != FuelType.Electricity)))
            {
                throw new ArgumentException($"Invalid fuel type '{fuelType}' for {model} ({automobileType}).");
            }

            AutomobileType = automobileType;
        }

        public string Model { get; private set; }
    }
}
