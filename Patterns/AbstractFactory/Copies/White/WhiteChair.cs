using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.Extensions;

namespace Patterns.AbstractFactory.Copies.White;

public sealed class WhiteChair : ChairBase
{
    public WhiteChair() : base(NameRandomizer.GenerateName(), "White")
    {
    }
}