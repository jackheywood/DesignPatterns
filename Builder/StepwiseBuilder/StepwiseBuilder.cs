using Builder.StepwiseBuilder.Builders;
using Utilities;
using static System.Console;

namespace Builder.StepwiseBuilder;

public class StepwiseBuilder : ConsoleProgram
{
    public StepwiseBuilder()
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