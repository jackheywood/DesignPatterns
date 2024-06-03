using System.Collections.ObjectModel;
using static System.Console;

namespace Adapter.SimpleAdapter;

public class LineToPointAdapter : Collection<Point>
{
    private static int _count;

    public LineToPointAdapter(Line line)
    {
        WriteLine($"\n{++_count}: Generating points for line {line.Start} to {line.End}");

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
                Add(new Point(left, y));
            }
        }
        else if (dy == 0)
        {
            for (var x = left; x <= right; ++x)
            {
                Add(new Point(x, bottom));
            }
        }
    }
}