using Utilities;

namespace Decorator.DecoratorExercise;

public class DecoratorExercise() : ConsoleProgram("Decorator Exercise")
{
    public override Task RunAsync()
    {
        var dragon = new Dragon();
        PrintDragon(dragon);

        dragon.Age = 20;
        PrintDragon(dragon);

        return Task.CompletedTask;
    }

    private static void PrintDragon(Dragon dragon)
    {
        WriteLine($"Dragon Aged {dragon.Age}");
        WriteLine($"Fly: {dragon.Fly().CapitalizeFirstLetter()}");
        WriteLine($"Crawl: {dragon.Crawl().CapitalizeFirstLetter()}");
        WriteLine();
    }
}