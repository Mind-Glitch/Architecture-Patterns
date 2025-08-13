using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.Extensions;

namespace Patterns.AbstractFactory.Copies.Black;

public sealed class BlackTable : TableBase
{
    public BlackTable() : base(NameRandomizer.GenerateName(), "Black")
    {
    }
}