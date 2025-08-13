using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.AbstractFactory.Copies.White;

namespace Patterns.AbstractFactory.Copies;

internal sealed class WhiteFurnitureFactory : IFurnitureFactory
{
    public SofaBase CreateSofa()
    {
        return new WhiteSofa();
    }

    public ChairBase CreateChair()
    {
        return new WhiteChair();
    }

    public TableBase CreateTable()
    {
        return new WhiteTable();
    }
}