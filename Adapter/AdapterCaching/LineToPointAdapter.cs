using System.Collections;

namespace Adapter.AdapterCaching;

public class LineToPointAdapter : IEnumerable<Point>
{
    private static int _count;

    private static readonly Dictionary<int, List<Point>> Cache = new();

    private readonly int _hashCode;

    public LineToPointAdapter(Line line)
    {
        _hashCode = line.GetHashCode();
        if (Cache.ContainsKey(_hashCode)) return;

        var points = GeneratePoints(line);
        Cache.Add(_hashCode, points);
    }

    public IEnumerator<Point> GetEnumerator() => Cache[_hashCode].GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static List<Point> GeneratePoints(Line line)
    {
        var points = new List<Point>();

        WriteLine($"{++_count}: Generating points for line {line.Start} to {line.End}");

        var left = Math.Min(line.Start.X, line.End.X);
        var right = Math.Max(line.Start.X, line.End.X);
        var bottom = Math.Min(line.Start.Y, line.End.Y);
        var top = Math.Max(line.Start.Y, line.End.Y);

        var dx = right - left;
        var dy = top - bottom;

        if (dx == 0)
        {
            for (var y = bottom; y <= top; ++y)
            {
                points.Add(new Point(left, y));
            }
        }
        else if (dy == 0)
        {
            for (var x = left; x <= right; ++x)
            {
                points.Add(new Point(x, bottom));
            }
        }

        return points;
    }
}