using MoreLinq;
using static System.Console;

namespace Singleton.SimpleSingleton;

public class SingletonDatabase : IDatabase
{
    private static readonly Lazy<SingletonDatabase> LazyInstance = new(() => new SingletonDatabase());

    private readonly Dictionary<string, int> _capitals;

    private SingletonDatabase()
    {
        WriteLine("Initializing database...");

        _capitals = File.ReadAllLines("SimpleSingleton/Capitals.txt")
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1))
            );
    }

    public static SingletonDatabase Instance => LazyInstance.Value;

    public int GetPopulation(string city) => _capitals[city];
}