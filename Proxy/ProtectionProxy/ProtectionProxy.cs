using Utilities;

namespace Proxy.ProtectionProxy;

public class ProtectionProxy() : ConsoleProgram("Protection Proxy")
{
    public override Task RunAsync()
    {
        var adult = new Driver(27);
        var child = new Driver(12);

        List<ICar> cars =
        [
            new CarProxy(child),
            new CarProxy(adult),
        ];

        foreach (var car in cars)
        {
            car.Drive();
        }

        return Task.CompletedTask;
    }
}