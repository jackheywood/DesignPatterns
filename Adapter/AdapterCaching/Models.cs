using System.Collections.ObjectModel;

namespace Adapter.AdapterCaching;

public class Point(int x, int y)
{
    public readonly int X = x;
    public readonly int Y = y;

    public override string ToString() => $"({X}, {Y})";

    public override int GetHashCode() => HashCode.Combine(X, Y);
}

public class Line(Point start, Point end)
{
    public readonly Point End = end;
    public readonly Point Start = start;

    public override int GetHashCode() => HashCode.Combine(End, Start);
}

public class VectorObject : Collection<Line>;

public class VectorRectangle : VectorObject
{
    public VectorRectangle(int x, int y, int width, int height)
    {
        Add(new Line(new Point(x, y), new Point(x + width, y)));
        Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
        Add(new Line(new Point(x, y), new Point(x, y + height)));
        Add(new Line(new Point(x, y + height), new Point(x + width, y + height)));
    }
}