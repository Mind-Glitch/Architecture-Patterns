namespace Patterns.AbstractFactory.Copies.Abstract;

public class TableBase : FurnitureBase
{
    public TableBase(string name, string color) : base(name, color)
    {
        Logger.Info($"[{GetName}], the {Color} table created!");
    }
}