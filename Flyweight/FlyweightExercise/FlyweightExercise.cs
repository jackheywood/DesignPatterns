using Utilities;

namespace Flyweight.FlyweightExercise;

public class FlyweightExercise() : ConsoleProgram("Flyweight Exercise")
{
    public override Task RunAsync()
    {
        var sentence = new Sentence("Hello world");
        sentence[1].Capitalize = true;
        WriteLine(sentence);

        return Task.CompletedTask;
    }
}