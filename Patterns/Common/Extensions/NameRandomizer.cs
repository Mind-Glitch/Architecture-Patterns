namespace Patterns.Extensions;

internal static class NameRandomizer
{
    private static readonly List<string> adjectives =
    [
        "Brave",
        "Silent",
        "Swift",
        "Bright",
        "Mighty",
        "Gentle",
        "Fierce",
        "Clever",
        "Noble",
        "Wild"
    ];

    private static readonly List<string> nouns =
    [
        "Falcon",
        "River",
        "Wolf",
        "Oak",
        "Hawk",
        "Shadow",
        "Star",
        "Lion",
        "Mountain",
        "Storm"
    ];

    internal static string GenerateName()
    {
        return $"{adjectives[Random.Shared.Next(adjectives.Count)]} " +
               $"{nouns[Random.Shared.Next(nouns.Count)]}";
    }
}