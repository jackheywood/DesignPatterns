using Autofac;
using Xunit;

namespace Singleton.DependencyInjection.Tests;

public class DependencyInjectionTests
{
    [Fact]
    public void DependencyInjection_InjectsDummyDatabase()
    {
        // Arrange
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterType<DummyDatabase>().As<IDatabase>().SingleInstance();
        containerBuilder.RegisterType<ConfigurableRecordFinder>();

        // Act
        using var container = containerBuilder.Build();
        var recordFinder = container.Resolve<ConfigurableRecordFinder>();
        var totalPopulation = recordFinder.GetTotalPopulation(["alpha", "gamma"]);

        // Assert
        Assert.Equal(1 + 3, totalPopulation);
    }
}