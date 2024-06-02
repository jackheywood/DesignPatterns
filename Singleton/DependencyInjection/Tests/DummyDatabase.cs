namespace Singleton.DependencyInjection.Tests;

public class DummyDatabase : IDatabase
{
    public int GetPopulation(string city) =>
        new Dictionary<string, int>
        {
            ["alpha"] = 1,
            ["beta"] = 2,
            ["gamma"] = 3,
        }[city];
}