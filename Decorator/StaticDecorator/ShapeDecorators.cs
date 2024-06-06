using Utilities;

namespace Decorator.StaticDecorator;

public class ColouredShape<T> : Shape where T : Shape, new()
{
    private readonly string _colour;
    private readonly T _shape = new();

    public ColouredShape() : this("black")
    { }

    public ColouredShape(string colour)
    {
        _colour = colour;
    }

    public override string AsString() => $"{_colour.CapitalizeFirstLetter()} {_shape.AsString().ToLower()}";
}

public class TransparentShape<T> : Shape where T : Shape, new()
{
    private readonly T _shape = new();
    private readonly float _transparency;

    public TransparentShape() : this(0)
    { }

    public TransparentShape(float transparency)
    {
        _transparency = transparency;
    }

    public override string AsString() => $"{_transparency * 100.0}% transparent {_shape.AsString().ToLower()}";
}