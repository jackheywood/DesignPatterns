using Xunit;

namespace Singleton.TestabilityIssues.Tests;

public class SingletonDatabaseTests
{
    [Fact]
    public void Database_IsSingleton()
    {
        // Arrange
        var db1 = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;

        // Assert
        Assert.Same(db1, db2);
        Assert.Equal(1, SingletonDatabase.Count);
    }
}