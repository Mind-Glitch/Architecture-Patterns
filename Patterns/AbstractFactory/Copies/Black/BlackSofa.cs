using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.Extensions;

namespace Patterns.AbstractFactory.Copies.Black;

public sealed class BlackSofa : SofaBase
{
    public BlackSofa() : base(NameRandomizer.GenerateName(), "Black")
    {
    }
}