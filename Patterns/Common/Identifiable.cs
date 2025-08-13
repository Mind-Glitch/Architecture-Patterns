using Patterns.Extensions;

namespace Patterns;

public class Identifiable : IIdentifiable
{
    public string GetName { get; } = NameRandomizer.GenerateName();
}