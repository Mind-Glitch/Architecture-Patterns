namespace Patterns;

// ReSharper disable once ClassNeverInstantiated.Global
// ReSharper disable once ArrangeTypeModifiers
class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main(string[] args)
    {
        Logger.Log("Architecture Patterns demonstration");
        Logger.Warning("Structural");
        /* Factory method */
        Logger.Log("\nFactoryMethod :");
        FactoryMethod.Demo.Run();

        /* AbstractFactory */
        Logger.Log("\nAbstractFactory :");
        AbstractFactory.Demo.Run();

        Logger.Log("\nBuilder :");
        Builder.Demo.Run();

        Logger.Log("\nPrototype :");
        Prototype.Demo.Run();
    }
}