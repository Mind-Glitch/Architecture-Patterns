using Patterns.Extensions;

namespace Patterns;

public class Identifiable : IIdentifiable
{
    protected Identifiable()
    {
        GetName = NameRandomizer.GenerateName();
    }

    protected Identifiable(string name)
    {
        GetName = name;
    }

    public string GetName { get; }
}