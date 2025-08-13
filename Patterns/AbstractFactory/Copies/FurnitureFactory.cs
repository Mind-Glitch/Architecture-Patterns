namespace Patterns.AbstractFactory.Copies;

public class FurnitureFactory
{
    public static IFurnitureFactory CreateWhiteFurnitureFactory()
    {
        return new WhiteFurnitureFactory();
    }

    public static IFurnitureFactory CreateBlackFurnitureFactory()
    {
        return new BlackFurnitureFactory();
    }
}