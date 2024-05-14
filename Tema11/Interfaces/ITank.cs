

namespace Tema11.Interfaces
{
    public enum FuelType
    {
        Gas,
        Diesel,
        LPG,
        Electricity
    }

    public interface ITank
    {
        FuelType FuelType { get; }
        double Capacity { get; }

        void Load(FuelType fuelType, double quantity);
        bool Refuel(IAutomobile vehicle, double quantity);
    }

}
