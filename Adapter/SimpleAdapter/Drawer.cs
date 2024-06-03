using MoreLinq;
using static System.Console;

namespace Adapter.SimpleAdapter;

public static class Drawer
{
    public static void Draw(IEnumerable<VectorObject> vectorObjects)
    {
        foreach (var line in vectorObjects.SelectMany(vo => vo))
        {
            new LineToPointAdapter(line).ForEach(DrawPoint);
        }
    }

    private static void DrawPoint(Point p)
    {
        Write(".");
    }
}