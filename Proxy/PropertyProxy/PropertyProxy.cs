using Utilities;

namespace Proxy.PropertyProxy;

public class PropertyProxy() : ConsoleProgram("Property Proxy")
{
    public override Task RunAsync()
    {
        var c = new Creature();
        c.Agility = 10;
        c.Agility = 10;
        c.Agility = 20;

        return Task.CompletedTask;
    }
}