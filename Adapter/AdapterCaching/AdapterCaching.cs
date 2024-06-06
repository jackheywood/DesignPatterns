using Utilities;

namespace Adapter.AdapterCaching;

public class AdapterCaching() : ConsoleProgram("Adapter Caching")
{
    private static readonly List<VectorObject> VectorObjects =
    [
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 6, 6),
    ];

    public override Task RunAsync()
    {
        // Generates a lot of temporary information
        Drawer.Draw(VectorObjects);
        Drawer.Draw(VectorObjects);
        WriteLine();

        return Task.CompletedTask;
    }
}