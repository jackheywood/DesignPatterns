using Utilities;
using static System.Console;

namespace Adapter.GenericValueAdapter;

public class GenericValueAdapter() : ConsoleProgram("Generic Value Adapter")
{
    public override Task RunAsync()
    {
        var v1 = Vector2I.Create(1, 2);
        var v2 = Vector2I.Create(3, -4);
        var v3 = v1 + v2;

        var v4 = Vector3F.Create(1.4f, 4.6f, -0.5f);
        var v5 = Vector3F.Create(2.9f, -5.1f, 4.7f);
        var v6 = v4 + v5;

        WriteLine("2D Integer Vectors");
        WriteLine($"A: {v1}");
        WriteLine($"B: {v2}");
        WriteLine($"Summed: {v3}");

        WriteLine("\n3D Float Vectors");
        WriteLine($"C: {v4}");
        WriteLine($"D: {v5}");
        WriteLine($"Summed: {v6}");

        return Task.CompletedTask;
    }
}