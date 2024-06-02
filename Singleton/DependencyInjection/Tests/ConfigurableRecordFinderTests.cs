using Xunit;

namespace Singleton.DependencyInjection.Tests;

public class ConfigurableRecordFinderTests
{
    [Fact]
    public void GetTotalPopulation_GetsTotalPopulation()
    {
        // Arrange
        var recordFinder = new ConfigurableRecordFinder(new DummyDatabase());
        var cities = new[] { "alpha", "beta", "gamma" };

        // Act
        var result = recordFinder.GetTotalPopulation(cities);

        // Assert
        Assert.Equal(1 + 2 + 3, result);
    }
}