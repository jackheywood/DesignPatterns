using Builder.Stepwise.Builders;
using ConsoleRunner;
using static System.Console;

namespace Builder.Stepwise;

public class Stepwise : ConsoleProgram
{
    public Stepwise()
    {
        Name = "Stepwise Builder";
    }

    public override void Run()
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