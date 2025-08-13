namespace Patterns.FactoryMethod.Copies;

public class Ship : TransportBase
{
    public override void Deliver()
    {
        Logger.Info($"Ship [{GetName}] is delivering ...");
    }

    public override void Recall()
    {
        Logger.Warning($"Ship [{GetName}] is recalled.");
    }
}