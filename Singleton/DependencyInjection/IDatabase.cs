namespace Singleton.DependencyInjection;

public interface IDatabase
{
    int GetPopulation(string city);
}