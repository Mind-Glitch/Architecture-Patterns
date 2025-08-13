namespace Patterns.Builder;

public static class Demo
{
    public static void Run()
    {
        var vehicle = new Vehicle()
            .SetEngine(Vehicle.EngineType.Modern)
            .SetBaseType(Vehicle.BaseType.Crossover)
            .SetFuelType(Vehicle.FuelType.Hybrid)
            .SetEnigneOilCapacity(3.0f)
            .SetFuelCapacity(12.0f);
        vehicle.PrintInfo();

        var vehicle2 = new Vehicle()
            .SetRandomEngine()
            .SetRandomBaseType()
            .SetRandomFuelType()
            .SetEnigneOilCapacity(2.8f)
            .SetFuelCapacity(8.0f);
        vehicle2.PrintInfo();
    }
}