using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema11.Interfaces;

namespace Tema11.CarData
{
    public class Car
    {
        public string Model { get; set; }
        public Guid Id { get; }
        public FuelType FuelType { get; set; }
        public double TankCapacity { get; set; }

        public Car(string model, FuelType fuelType, double tankCapacity)
        {
            Model = model;
            Id = Guid.NewGuid();
            FuelType = fuelType;
            TankCapacity = tankCapacity;
        }

        public string Describe()
        {
            return $"Model: {Model}, ID: {Id}, FuelType: {FuelType}, Capacity: {TankCapacity}";
        }
    }

}
