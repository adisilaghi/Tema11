using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema11.Interfaces;


namespace Tema11
{
    public class FuelingTank : ITank
    {
        public FuelType FuelType { get; private set; }
        public double Capacity { get; private set; }
        public double FuelAmount { get; private set; }

        public FuelingTank(FuelType fuelType, double capacity)
        {
            FuelType = fuelType;
            Capacity = capacity;
            FuelAmount = 0;
        }

        public void Load(FuelType fuelType, double quantity)
        {
            if (FuelType != fuelType)
            {
                throw new InvalidOperationException("Cannot load different fuel type into the tank.");
            }

            if (FuelAmount + quantity > Capacity)
            {
                throw new InvalidOperationException($"Tank capacity exceeded for {fuelType}.");
            }

            FuelAmount += quantity;
        }

        public bool Refuel(IAutomobile vehicle, double quantity)
        {
            if (FuelAmount < quantity)
            {
                throw new InvalidOperationException("Not enough fuel in the tank.");
            }

            if (FuelType != vehicle.FuelType)
            {
                throw new InvalidOperationException("Incompatible fuel type.");
            }

            FuelAmount -= quantity;
            return true;
        }
    }


}
