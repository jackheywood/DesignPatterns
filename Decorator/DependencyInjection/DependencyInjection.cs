using Autofac;
using Utilities;

namespace Decorator.DependencyInjection;

public class DependencyInjection() : ConsoleProgram("Decorator in Dependency Injection")
{
    private const string ReportingKey = "Reporting";

    public override Task RunAsync()
    {
        var cb = new ContainerBuilder();

        cb.RegisterType<ReportingService>().Named<IReportingService>(ReportingKey);
        cb.RegisterDecorator<IReportingService>((_, service) => new ReportingServiceWithLogging(service), ReportingKey);

        using (var c = cb.Build())
        {
            var reportingService = c.Resolve<IReportingService>();
            reportingService.Report();
        }

        return Task.CompletedTask;
    }
}