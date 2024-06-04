using Utilities;
using static System.Console;

namespace Composite.GeometricShapes;

public class GeometricShapes() : ConsoleProgram("Composite Geometric Shapes")
{
    public override Task RunAsync()
    {
        var drawing = new GraphicObject { Name = "My Drawing" };
        drawing.AddChild(new Square { Colour = "Red" });
        drawing.AddChild(new Circle { Colour = "Green" });

        var group = new GraphicObject();
        group.AddChild(new Circle { Colour = "Blue" });
        group.AddChild(new Square { Colour = "Purple" });

        drawing.AddChild(group);

        WriteLine(drawing);

        return Task.CompletedTask;
    }
}