namespace Patterns;

// ReSharper disable once ClassNeverInstantiated.Global
// ReSharper disable once ArrangeTypeModifiers
class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main(string[] args)
    {
        Logger.Log("Architecture Patterns demonstration");

        /* Factory method */
        Logger.Info("FactoryMethod :");
        FactoryMethod.Demo.Run();

        /* AbstractFactory */
        Logger.Info("AbstractFactory :");
        AbstractFactory.Demo.Run();
    }
}