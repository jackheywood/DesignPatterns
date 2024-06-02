using Autofac;
using Utilities;
using static System.Console;

namespace Singleton.DependencyInjection;

public class DependencyInjection() : ConsoleProgram("Singleton in Dependency Injection")
{
    public override Task RunAsync()
    {
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
        containerBuilder.RegisterType<ConfigurableRecordFinder>();

        using (var container = containerBuilder.Build())
        {
            var recordFinder = container.Resolve<ConfigurableRecordFinder>();
            var totalPopulation = recordFinder.GetTotalPopulation(["Hong Kong", "Bangkok"]);
            WriteLine($"Total population of Hong Kong & Bangkok: {totalPopulation}");
        }
        
        return Task.CompletedTask;
    }
}