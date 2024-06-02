namespace Singleton.AmbientContext;

public class Building
{
    public List<Wall> Walls = [];

    public override string ToString() => $"{nameof(Walls)}:\n- {string.Join("\n- ", Walls)}";
}

public class Wall(Point start, Point end)
{
    public int Height = BuildingContext.Current.WallHeight;
    public Point Start = start, End = end;

    public override string ToString() => $"{nameof(Height)}: {Height}, {nameof(Start)}: {Start}, {nameof(End)}: {End}";
}

public readonly struct Point(int x, int y)
{
    public override string ToString() => $"({x}, {y})";
}