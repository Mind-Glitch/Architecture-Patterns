namespace Patterns.FactoryMethod.Copies;

public class Car : TransportBase
{
    public override void Deliver()
    {
        Logger.Info("Car is delivering ...");
    }

    public override void Recall()
    {
        Logger.Warning("Car is recalled.");
    }
}