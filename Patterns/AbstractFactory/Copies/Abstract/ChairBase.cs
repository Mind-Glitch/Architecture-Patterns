namespace Patterns.AbstractFactory.Copies.Abstract;

public class ChairBase : FurnitureBase
{
    protected ChairBase(string name, string color) : base(name, color)
    {
        Logger.Info($"[{GetName}], the {Color} chair created!");
    }
}