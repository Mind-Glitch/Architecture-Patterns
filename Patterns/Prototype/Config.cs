using System.Text;

namespace Patterns.Prototype;

public class Config : Identifiable, IPrototype<Config>
{
    public Config()
    {
    }

    public Config(string name) : base(name)
    {
    }

    private string _field1 = "field1";
    private string _field2 = "field2";

    public void Operation()
    {
        _field1 = "new field1";
        _field2 = "new field2";
    }

    public Config Clone()
    {
        var config = new Config(GetName)
        {
            _field1 = _field1,
            _field2 = _field2
        };
        return config;
    }

    public void Print()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Config object [{GetName}] has:");
        sb.AppendLine($"Hidden Field1: {_field1}");
        sb.AppendLine($"Hidden Field2: {_field2}");
        Logger.Info(sb.ToString());
    }
}