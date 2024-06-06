using Utilities;

namespace Prototype.PrototypeExercise;

public class PrototypeExercise() : ConsoleProgram("Prototype Exercise")
{
    public override Task RunAsync()
    {
        var line1 = new Line
        {
            Start = new Point { X = 3, Y = 3 },
            End = new Point { X = 10, Y = 10 },
        };

        var line2 = line1.DeepCopy();
        line1.Start.X = line1.End.X = line1.Start.Y = line1.End.Y = 0;

        WriteLine(line1);
        WriteLine(line2);

        return Task.CompletedTask;
    }
}