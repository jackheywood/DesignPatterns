using Utilities;
using static System.Console;

namespace Decorator.DecoratorCycles;

public class DecoratorCycles() : ConsoleProgram("Detecting Decorator Cycles")
{
    public override Task RunAsync()
    {
        var circle = new Circle(2);

        var colouredCircle1 = new ColouredShape(circle, "Red");
        var colouredCircle2 = new ColouredShape(colouredCircle1, "Blue");
        WriteLine(colouredCircle2.AsString());

        var square = new Square(5);

        var transparentSquare1 = new TransparentShape(square, 0.5f);
        var transparentSquare2 = new TransparentShape(transparentSquare1, 0.25f);
        WriteLine(transparentSquare2.AsString());

        var triangle = new Triangle(3, 4, 5);

        try
        {
            var specialTriangle1 = new SpecialShape(triangle);
            var specialTriangle2 = new SpecialShape(specialTriangle1);
            WriteLine(specialTriangle2.AsString());
        }
        catch (InvalidOperationException ex)
        {
            WriteLine(ex.Message);
        }

        return Task.CompletedTask;
    }
}