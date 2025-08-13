using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.Extensions;

namespace Patterns.AbstractFactory.Copies.Black;

public sealed class BlackChair : ChairBase
{
    public BlackChair() : base(NameRandomizer.GenerateName(), "Black")
    {
    }
}