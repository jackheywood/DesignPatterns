using Utilities;

namespace Decorator.DynamicDecorator;

public class DynamicDecorator() : ConsoleProgram("Dynamic Decorator Composition")
{
    public override Task RunAsync()
    {
        List<IShape> shapes =
        [
            new Square(1.5f),
            new ColouredShape(new Circle(3.14f), "Blue"),
            new TransparentShape(new Square(6.58f), 0.5f),
            new TransparentShape(new ColouredShape(new Circle(8.9f), "Red"), 0.75f),
        ];

        foreach (var shape in shapes) WriteLine(shape.AsString());

        // Nothing stopping us from nesting the same decorator!
        // Could keep track of which types have been applied to avoid this being possible - See DecoratorCycles
        var sillyShape = new TransparentShape(new TransparentShape(new Circle(1.5f), 0.25f), 0.125f);
        WriteLine(sillyShape.AsString());

        return Task.CompletedTask;
    }
}