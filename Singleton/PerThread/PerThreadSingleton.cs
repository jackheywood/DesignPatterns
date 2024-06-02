namespace Singleton.PerThread;

public sealed class PerThreadSingleton
{
    private static readonly ThreadLocal<PerThreadSingleton> ThreadInstance = new(() => new PerThreadSingleton());

    public int Id;

    private PerThreadSingleton()
    {
        Id = Environment.CurrentManagedThreadId;
    }

    public static PerThreadSingleton Instance => ThreadInstance.Value;
}