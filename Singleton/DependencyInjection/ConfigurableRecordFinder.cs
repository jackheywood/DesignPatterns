namespace Singleton.DependencyInjection;

public class ConfigurableRecordFinder(IDatabase database)
{
    public int GetTotalPopulation(IEnumerable<string> names) => names.Sum(database.GetPopulation);
}