using Factory.FactoryClass.Factories;
using Utilities;

namespace Factory.FactoryClass;

public class FactoryClass() : ConsoleProgram("Factory Class")
{
    public override Task RunAsync()
    {
        var polarPoint = PointFactory.NewPolarPoint(2.5, Math.PI);
        WriteLine($"Polar:\t\t{polarPoint}");

        var cartesianPoint = PointFactory.NewCartesianPoint(2.1, -6.5);
        WriteLine($"Cartesian:\t{cartesianPoint}");

        return Task.CompletedTask;
    }
}