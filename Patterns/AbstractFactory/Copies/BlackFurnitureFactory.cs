using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.AbstractFactory.Copies.Black;

namespace Patterns.AbstractFactory.Copies;

internal sealed class BlackFurnitureFactory : IFurnitureFactory
{
    public SofaBase CreateSofa()
    {
        return new BlackSofa();
    }

    public ChairBase CreateChair()
    {
        return new BlackChair();
    }

    public TableBase CreateTable()
    {
        return new BlackTable();
    }
}