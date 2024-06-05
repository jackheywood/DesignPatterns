using Utilities;
using static System.Console;

namespace Composite.CompositeExercise;

public class CompositeExercise() : ConsoleProgram("Composite Exercise")
{
    public override Task RunAsync()
    {
        var singleValue = new SingleValue { Value = 15 };
        var manyValues = new ManyValues { 22, 37, -3 };

        List<IValueContainer> containers = [singleValue, manyValues];
        
        WriteLine(singleValue);
        WriteLine(manyValues);
        WriteLine($"Sum: {containers.Sum()}");

        return Task.CompletedTask;
    }
}