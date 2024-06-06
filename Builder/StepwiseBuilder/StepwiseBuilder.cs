using Builder.StepwiseBuilder.Builders;
using Utilities;

namespace Builder.StepwiseBuilder;

public class StepwiseBuilder() : ConsoleProgram("Stepwise Builder")
{
    public override Task RunAsync()
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

        return Task.CompletedTask;
    }
}