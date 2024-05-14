using Tema11.Interfaces;
using Tema11;

FuelingCar car1 = new FuelingCar("Audi", "Gas", FuelType.Gas, 50);
Console.WriteLine(car1.Describe());
car1.Refuel(40);
FuelingCar car2 = new FuelingCar("Honda", "Diesel", FuelType.Diesel, 150);
Console.WriteLine(car2.Describe());
car2.Refuel(130);
FuelingCar car3 = new FuelingCar("Suzuki", "LPG", FuelType.LPG, 150);
Console.WriteLine(car3.Describe());
car3.Refuel(150);
FuelingCar car4 = new FuelingCar("Toyota Hybrid", "Hybrid", FuelType.Gas | FuelType.Electricity, 70);
Console.WriteLine(car4.Describe());
car4.Refuel(70);

try
{
    FuelingTank gasTank = new FuelingTank(FuelType.Gas, 100);
    gasTank.Load(FuelType.Gas, 150);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    FuelingTank dieselTank = new FuelingTank(FuelType.Diesel, 100);
    dieselTank.Load(FuelType.Diesel, 50);
    Console.WriteLine("Diesel tank successfully loaded");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
    