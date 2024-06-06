using System.Text;

namespace Decorator.DecoratorCycles;

public abstract class ShapeDecorator : Shape
{
    protected readonly Shape Shape;
    protected readonly List<Type> Types = [];

    protected ShapeDecorator(Shape shape)
    {
        Shape = shape;
        if (shape is ShapeDecorator sd)
        {
            Types.AddRange(sd.Types);
        }
    }
}

public abstract class ShapeDecorator<TSelf, TPolicy> : ShapeDecorator where TPolicy : ShapeDecoratorCyclePolicy, new()
{
    protected readonly TPolicy Policy = new();

    protected ShapeDecorator(Shape shape) : base(shape)
    {
        if (Policy.TypeAdditionAllowed(typeof(TSelf), Types))
        {
            Types.Add(typeof(TSelf));
        }
    }
}

public class ColouredShape(Shape shape, string colour)
    : ShapeDecorator<ColouredShape, AbsorbCyclePolicy>(shape)
{
    public override string AsString()
    {
        var sb = new StringBuilder(Shape.AsString());

        if (Policy.ApplicationAllowed(Types[0], Types.Skip(1).ToList()))
        {
            sb.Append($" coloured {colour}");
        }

        return sb.ToString();
    }
}

public class TransparentShape(Shape shape, float transparency)
    : ShapeDecorator<TransparentShape, CyclesAllowedPolicy>(shape)
{
    public override string AsString() => $"{transparency * 100.0}% transparent {Shape.AsString().ToLower()}";
}

public class SpecialShape(Shape shape) : ShapeDecorator<SpecialShape, ThrowOnCyclePolicy>(shape)
{
    public override string AsString() => $"Special {Shape.AsString().ToLower()}";
}