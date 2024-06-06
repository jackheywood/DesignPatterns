namespace Decorator.DynamicDecorator;

public class ColouredShape(IShape shape, string colour) : IShape
{
    public string AsString() => $"{colour} {shape.AsString().ToLower()}";
}

public class TransparentShape(IShape shape, float transparency) : IShape
{
    public string AsString() => $"{transparency * 100.0}% transparent {shape.AsString().ToLower()}";
}