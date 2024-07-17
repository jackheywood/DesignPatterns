using Utilities;

namespace Proxy.ValueProxy;

public class ValueProxy() : ConsoleProgram("Value Proxy")
{
    public override Task RunAsync()
    {
        WriteLine(10f * 5.Percent());
        WriteLine(2.Percent() + 3.Percent());

        return Task.CompletedTask;
    }
}