using Utilities;

namespace Bridge.BridgeExample;

public class BridgeExample() : ConsoleProgram("Bridge Example")
{
    public override Task RunAsync()
    {
        var rasterRenderer = new RasterRenderer();
        var rasterCircle = new Circle(rasterRenderer, 5.2f);

        rasterCircle.Draw();
        rasterCircle.Resize(2);
        rasterCircle.Draw();

        var vectorRenderer = new VectorRenderer();
        var vectorCircle = new Circle(vectorRenderer, 8.6f);

        vectorCircle.Draw();
        vectorCircle.Resize(0.5f);
        vectorCircle.Draw();

        return Task.CompletedTask;
    }
}