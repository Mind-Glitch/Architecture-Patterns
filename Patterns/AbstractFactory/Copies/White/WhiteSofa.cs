using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.Extensions;

namespace Patterns.AbstractFactory.Copies.White;

public sealed class WhiteSofa : SofaBase
{
    public WhiteSofa() : base(NameRandomizer.GenerateName(), "White")
    {
    }
}