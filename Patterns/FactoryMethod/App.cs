namespace Patterns.FactoryMethod;

public class Demo
{
    public static void Run()
    {
        Logger.Info("Factory method demo :\n");
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