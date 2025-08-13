namespace Patterns.AbstractFactory.Copies.Abstract;

public class FurnitureBase : Identifiable
{
    public string Color { get; private set; }

    public FurnitureBase(string name, string color) : base(name)
    {
        Color = color;
    }
}