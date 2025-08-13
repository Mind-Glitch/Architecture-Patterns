using System.Text;
using Patterns.Extensions;

namespace Patterns.Builder;

public class Vehicle
{
    public enum EngineType
    {
        Rusty,
        Old,
        Classic,
        Modern,
        SciFi
    }

    public enum BaseType
    {
        Sedan,
        Coupe,
        Hatchback,
        Liftback,
        Fastback,
        StationWagon,
        Crossover,
        SUV,
    }

    public enum FuelType
    {
        Diesel,
        Electric,
        Hybrid,
        Petrol,
    }

    private EngineType _engineType = EngineType.Classic;
    private BaseType _baseType = BaseType.Sedan;
    private float _fuelCapacity = 1.0f;
    private float _enigneOilCapacity = 1.0f;
    private FuelType _fuelType = FuelType.Petrol;
    private string _vehicleName = NameRandomizer.GenerateName();

    internal Vehicle SetEngine(EngineType engineType)
    {
        _engineType = engineType;
        return this;
    }

    internal Vehicle SetRandomEngine()
    {
        var count = Enum.GetValues<EngineType>().Length - 1;
        _engineType = Enum.GetValues<EngineType>()[Random.Shared.Next(0, count)];
        return this;
    }

    internal Vehicle SetBaseType(BaseType baseType)
    {
        _baseType = baseType;
        return this;
    }

    internal Vehicle SetRandomBaseType()
    {
        var count = Enum.GetValues<BaseType>().Length - 1;
        _baseType = Enum.GetValues<BaseType>()[Random.Shared.Next(0, count)];
        return this;
    }

    internal Vehicle SetFuelType(FuelType fuelType)
    {
        _fuelType = fuelType;
        return this;
    }

    internal Vehicle SetRandomFuelType()
    {
        var count = Enum.GetValues<FuelType>().Length - 1;
        _fuelType = Enum.GetValues<FuelType>()[Random.Shared.Next(0, count)];
        return this;
    }

    internal Vehicle SetFuelCapacity(float fuelCapacity)
    {
        _fuelCapacity = fuelCapacity;
        return this;
    }

    internal Vehicle SetEnigneOilCapacity(float enigneOilCapacity)
    {
        _enigneOilCapacity = enigneOilCapacity;
        return this;
    }

    public void PrintInfo()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Vehicle: {_vehicleName},");

        sb.AppendLine($"Engine: {_engineType.ToString()},");
        sb.AppendLine($"Base: {_baseType.ToString()},");
        sb.AppendLine($"Fuel Type: {_fuelType.ToString()}");
        sb.AppendLine($"Fuel Capacity: {_fuelCapacity},");

        sb.AppendLine($"Enigne Oil Capacity: {_enigneOilCapacity}");

        Logger.Info(sb.ToString());
    }
}