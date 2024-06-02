namespace Singleton.AmbientContext;

public sealed class BuildingContext : IDisposable
{
    private static readonly Stack<BuildingContext> ContextStack = new();

    public readonly int WallHeight;

    static BuildingContext()
    {
        ContextStack.Push(new BuildingContext(0));
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        ContextStack.Push(this);
    }

    public static BuildingContext Current => ContextStack.Peek();

    public void Dispose()
    {
        if (ContextStack.Count > 1) ContextStack.Pop();
    }
}