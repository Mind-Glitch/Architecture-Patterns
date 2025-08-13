namespace Patterns.FactoryMethod.Copies;

internal class Truck : TransportBase
{
    public override void Deliver()
    {
        Logger.Info($"Truck [{GetName}] is delivering ...");
    }

    public override void Recall()
    {
        Logger.Warning($"Truck [{GetName}] is recalled");
    }
}