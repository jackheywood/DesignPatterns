using Utilities;
using static System.Console;

namespace Singleton.SimpleSingleton;

public class SimpleSingleton() : ConsoleProgram("Simple Singleton")
{
    public override Task RunAsync()
    {
        var db1 = SingletonDatabase.Instance;
        var londonPopulation = db1.GetPopulation("London");
        WriteLine($"London: {londonPopulation}");

        var db2 = SingletonDatabase.Instance;
        var melbournePopulation = db2.GetPopulation("Melbourne");
        WriteLine($"Melbourne: {melbournePopulation}");

        return Task.CompletedTask;
    }
}