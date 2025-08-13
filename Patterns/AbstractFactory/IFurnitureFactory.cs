using Patterns.AbstractFactory.Copies.Abstract;

namespace Patterns.AbstractFactory;

public interface IFurnitureFactory
{
    public SofaBase CreateSofa();
    public ChairBase CreateChair();
    public TableBase CreateTable();
}