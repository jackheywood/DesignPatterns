using Xunit;

namespace Singleton.TestabilityIssues.Tests;

public class SingletonRecordFinderTests
{
    // Dependent on the live data, as SingletonRecordFinder has a hard-coded reference to the database
    // Can't replace with a test instance!
    [Fact]
    public void GetTotalPopulation_GetsTotalPopulation()
    {
        // Arrange
        var cities = new[] { "Toronto", "Paris" };

        // Act
        var result = SingletonRecordFinder.GetTotalPopulation(cities);

        // Assert
        Assert.Equal(6082000 + 2161000, result);
    }
}