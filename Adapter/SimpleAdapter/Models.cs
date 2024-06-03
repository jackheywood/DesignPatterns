using System.Collections.ObjectModel;

namespace Adapter.SimpleAdapter;

public class Point(int x, int y)
{
    public int X = x;
    public int Y = y;

    public override string ToString() => $"({X}, {Y})";
}

public class Line(Point start, Point end)
{
    public Point End = end;
    public Point Start = start;
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