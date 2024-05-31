using Utilities;
using static System.Console;

namespace Factory.InnerFactory;

public class InnerFactory() : ConsoleProgram("Inner Factory")
{
    public override Task RunAsync()
    {
        var polarPoint = Point.Factory.NewPolarPoint(1.7, Math.PI);
        WriteLine($"Polar:\t\t{polarPoint}");

        var cartesianPoint = Point.Factory.NewCartesianPoint(-0.1, 7.2);
        WriteLine($"Cartesian:\t{cartesianPoint}");

        return Task.CompletedTask;
    }
}