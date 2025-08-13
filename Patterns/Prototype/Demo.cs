namespace Patterns.Prototype;

public class Demo
{
    public static void Run()
    {
        Config config = new Config();

        Logger.Log("Before operation:");
        config.Print();

        Logger.Log("After operation:");
        config.Operation();
        config.Print();

        Logger.Log("New Config:");
        var config2 = new Config();
        config2.Print();

        Logger.Log("Replace new Config with first's prototype after operation :");
        config2 = config.Clone();
        config2.Print();
    }
}