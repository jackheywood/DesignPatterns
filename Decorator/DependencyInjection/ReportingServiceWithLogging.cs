namespace Decorator.DependencyInjection;

public class ReportingServiceWithLogging(IReportingService decorated) : IReportingService
{
    public void Report()
    {
        WriteLine("Commencing log...");
        decorated.Report();
        WriteLine("Ending log...");
    }
}