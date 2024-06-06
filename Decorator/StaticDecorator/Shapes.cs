namespace Decorator.StaticDecorator;

public abstract class Shape
{
    public abstract string AsString();
}

public class Circle : Shape
{
    private readonly float _radius;

    public Circle() : this(0)
    { }

    public Circle(float radius)
    {
        _radius = radius;
    }

    public override string AsString() => $"Circle with radius {_radius}";
}

public class Square : Shape
{
    private readonly float _side;

    public Square() : this(0)
    { }

    public Square(float side)
    {
        _side = side;
    }

    public override string AsString() => $"Square with sides {_side}";
}