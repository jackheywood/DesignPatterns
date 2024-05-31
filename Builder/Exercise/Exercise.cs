using Builder.Exercise.Builders;
using Utilities;

namespace Builder.Exercise;

public class Exercise : ConsoleProgram
{
    public Exercise()
    {
        Name = "Code Builder Exercise";
    }

    public override void Run()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");

        Console.WriteLine(cb);
    }
}