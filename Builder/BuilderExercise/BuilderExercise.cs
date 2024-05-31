using Builder.BuilderExercise.Builders;
using Utilities;

namespace Builder.BuilderExercise;

public class BuilderExercise() : ConsoleProgram("Code Builder Exercise")
{
    public override Task RunAsync()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");

        Console.WriteLine(cb);

        return Task.CompletedTask;
    }
}