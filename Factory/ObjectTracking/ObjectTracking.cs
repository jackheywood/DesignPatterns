using Factory.ObjectTracking.Factories;
using Utilities;

namespace Factory.ObjectTracking;

public class ObjectTracking() : ConsoleProgram("Object Tracking")
{
    public override Task RunAsync()
    {
        var factory = new TrackingThemeFactory();

        var theme1 = factory.CreateTheme(false);
        var theme2 = factory.CreateTheme(true);

        Write(factory.Info);

        return Task.CompletedTask;
    }
}