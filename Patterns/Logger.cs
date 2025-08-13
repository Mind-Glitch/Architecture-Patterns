using System;

namespace Patterns;

internal static class Logger
{
    internal static void Log(string message) =>
        Console.WriteLine($"[LOG]: {message}");

    internal static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[Error]: {message}");
        Console.ResetColor();
    }

    internal static void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[Warning]: {message}");
        Console.ResetColor();
    }

    internal static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"[Information]: {message}");
        Console.ResetColor();
    }
}