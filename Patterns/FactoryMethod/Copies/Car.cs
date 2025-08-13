namespace Patterns.FactoryMethod.Copies;

public class Car : TransportBase
{
    public override void Deliver()
    {
        Logger.Info($"Car [{GetName}] is delivering ...");
    }

    public override void Recall()
    {
        Logger.Warning($"Car [{GetName}] is recalled.");
    }
}