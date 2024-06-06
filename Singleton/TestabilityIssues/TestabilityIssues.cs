using Utilities;

namespace Singleton.TestabilityIssues;

public class TestabilityIssues() : ConsoleProgram("Testability Issues")
{
    public override Task RunAsync()
    {
        var totalPopulation = SingletonRecordFinder.GetTotalPopulation(["Tokyo", "New York"]);
        WriteLine($"Total population of Tokyo & New York: {totalPopulation}");

        return Task.CompletedTask;
    }
}