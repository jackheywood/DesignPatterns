namespace Prototype.PrototypeExercise;

public class Point : IDeepCopyable<Point>
{
    public int X;
    public int Y;

    public Point DeepCopy() => new() { X = X, Y = Y };

    public override string ToString() => $"({X}, {Y})";
}