using Builder.Stepwise.Builders;
using static System.Console;

namespace Builder.Stepwise;

public static class Stepwise
{
    public static void Run()
    {
        try
        {
            var car = CarBuilder.Create() // ISpecifyCarType
                .OfType(CarType.Crossover) // ISpecifyWheelSize
                .WithWheels(18) // IBuildCar
                .Build();
            
            WriteLine(car);
        }
        catch (ArgumentException ex)
        {
            WriteLine(ex.Message);
        }
    }
}