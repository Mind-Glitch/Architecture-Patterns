using Patterns.FactoryMethod.Copies;

namespace Patterns.FactoryMethod;

public static class DeliveryUnitFactory
{
    internal static IDeliveryUnit CreateTruck()
    {
        return new Truck( /* params */ );
    }

    internal static IDeliveryUnit CreateShip()
    {
        return new Ship( /* params */ );
    }

    internal static IDeliveryUnit CreateCar()
    {
        return new Car( /* params */ );
    }
}