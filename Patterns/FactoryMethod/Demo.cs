namespace Patterns.FactoryMethod;

public static class Demo
{
    public static void Run()
    {
        IDeliveryUnit truck = DeliveryUnitFactory.CreateTruck();
        IDeliveryUnit car = DeliveryUnitFactory.CreateCar();
        IDeliveryUnit ship = DeliveryUnitFactory.CreateShip();

        truck.Deliver();
        ship.Deliver();
        car.Deliver();

        truck.Recall();
        ship.Recall();
        car.Recall();
    }
}