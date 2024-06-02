namespace Singleton.TestabilityIssues;

public static class SingletonRecordFinder
{
    public static int GetTotalPopulation(IEnumerable<string> cities)
    {
        // Hard-coded reference to the database instance! Can't substitute when testing
        return cities.Sum(city => SingletonDatabase.Instance.GetPopulation(city));
    }
}