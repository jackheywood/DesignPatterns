using Utilities;
using static System.Console;

namespace Factory.FactoryMethod;

public class FactoryMethod() : ConsoleProgram("Factory Method")
{
    public override Task RunAsync()
    {
        var polarPoint = Point.NewPolarPoint(1.0, Math.PI / 2);
        WriteLine($"Polar:\t\t{polarPoint}");

        var cartesianPoint = Point.NewCartesianPoint(4.0, 5.5);
        WriteLine($"Cartesian:\t{cartesianPoint}");

        return Task.CompletedTask;
    }
}