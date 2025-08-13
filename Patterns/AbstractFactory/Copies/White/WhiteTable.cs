using Patterns.AbstractFactory.Copies.Abstract;
using Patterns.Extensions;

namespace Patterns.AbstractFactory.Copies.White;

public sealed class WhiteTable : TableBase
{
    public WhiteTable() : base(NameRandomizer.GenerateName(), "White")
    {
    }
}