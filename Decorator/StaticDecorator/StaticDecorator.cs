using Utilities;

namespace Decorator.StaticDecorator;

// Doesn't really work in C#
public class StaticDecorator() : ConsoleProgram("Static Decorator Composition")
{
    public override Task RunAsync()
    {
        // Can only set colour
        var redSquare = new ColouredShape<Square>("red");
        WriteLine(redSquare.AsString());

        // Can only set transparency
        var transparentColouredCircle = new TransparentShape<ColouredShape<Circle>>(0.4f);
        WriteLine(transparentColouredCircle.AsString());

        return Task.CompletedTask;
    }
}