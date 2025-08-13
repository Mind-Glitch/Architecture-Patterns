using Patterns.AbstractFactory.Copies;

namespace Patterns.AbstractFactory;

public static class Demo
{
    public static void Run()
    {
        var whiteFactory = FurnitureFactory.CreateWhiteFurnitureFactory();
        var blackFactory = FurnitureFactory.CreateBlackFurnitureFactory();

        whiteFactory.CreateSofa();
        blackFactory.CreateSofa();

        whiteFactory.CreateTable();
        blackFactory.CreateTable();

        whiteFactory.CreateChair();
        blackFactory.CreateChair();
    }
}