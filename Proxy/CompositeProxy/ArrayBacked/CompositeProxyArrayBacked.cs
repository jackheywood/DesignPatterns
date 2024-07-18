using Utilities;

namespace Proxy.CompositeProxy.ArrayBacked;

public class CompositeProxyArrayBacked() : ConsoleProgram("Composite Proxy: Array-Backed Properties")
{
    public override Task RunAsync()
    {
        var standard = new MasonrySettingsStandard { All = false };
        WriteLine($"Standard:\n{standard}\n");

        var arrayBacked = new MasonrySettingsArrayBacked { All = true };
        WriteLine($"Array-backed:\n{arrayBacked}\n");

        return Task.CompletedTask;
    }
}