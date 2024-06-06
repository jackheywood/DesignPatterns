namespace Decorator.DecoratorCycles;

public abstract class Shape
{
    public virtual string AsString() => string.Empty;
}

public class Circle(float radius) : Shape
{
    public override string AsString() => $"Circle with radius {radius}";
}

public class Square(float side) : Shape
{
    public override string AsString() => $"Square with sides {side}";
}

public class Triangle(float side1, float side2, float side3) : Shape
{
    public override string AsString() => $"Triangle with sides {side1}, {side2}, {side3}";
}