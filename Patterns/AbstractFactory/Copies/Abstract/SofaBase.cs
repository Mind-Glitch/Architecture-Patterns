namespace Patterns.AbstractFactory.Copies.Abstract;

public class SofaBase : FurnitureBase
{
    protected SofaBase(string name, string color) : base(name, color)
    {
        Logger.Info($"[{GetName}], the {Color} sofa created!");
    }
}