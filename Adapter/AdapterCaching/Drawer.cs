using MoreLinq;

namespace Adapter.AdapterCaching;

public static class Drawer
{
    public static void Draw(IEnumerable<VectorObject> vectorObjects)
    {
        foreach (var line in vectorObjects.SelectMany(vo => vo))
        {
            new LineToPointAdapter(line).ForEach(DrawPoint);
            WriteLine();
        }
    }

    private static void DrawPoint(Point p)
    {
        Write(".");
    }
}