namespace Decorator.DynamicDecorator;

public interface IShape
{
    string AsString();
}

public class Circle(float radius) : IShape
{
    public string AsString() => $"Circle with radius {radius}";

    public void Resize(float factor)
    {
        radius *= factor;
    }
}

public class Square(float side) : IShape
{
    public string AsString() => $"Square with sides {side}";
}