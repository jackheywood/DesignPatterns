using Utilities;

namespace Bridge.BridgeExercise;

public class BridgeExercise() : ConsoleProgram("Bridge Exercise")
{
    public override Task RunAsync()
    {
        var vectorRenderer = new VectorRenderer();
        var rasterRenderer = new RasterRenderer();

        WriteLine(new Triangle(vectorRenderer).ToString());
        WriteLine(new Triangle(rasterRenderer).ToString());
        WriteLine(new Square(vectorRenderer).ToString());
        WriteLine(new Square(rasterRenderer).ToString());

        return Task.CompletedTask;
    }
}