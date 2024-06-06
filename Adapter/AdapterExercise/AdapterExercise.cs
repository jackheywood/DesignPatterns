using Utilities;

namespace Adapter.AdapterExercise;

public class AdapterExercise() : ConsoleProgram("Adapter Exercise")
{
    public override Task RunAsync()
    {
        var square = new Square { Side = 5 };
        var adapter = new SquareToRectangleAdapter(square);
        WriteLine(adapter.Area());

        return Task.CompletedTask;
    }
}