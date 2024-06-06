using MoreLinq;

namespace Singleton.DependencyInjection;

public class OrdinaryDatabase : IDatabase
{
    private static readonly string DatabaseFilePath = Path.Combine(
        new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName!, "DependencyInjection/Capitals.txt");

    private readonly Dictionary<string, int> _capitals;

    public OrdinaryDatabase()
    {
        WriteLine("Initializing database...");

        _capitals = File.ReadAllLines(DatabaseFilePath)
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1))
            );
    }

    public int GetPopulation(string city) => _capitals[city];
}