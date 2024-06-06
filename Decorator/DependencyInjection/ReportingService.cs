namespace Decorator.DependencyInjection;

public interface IReportingService
{
    void Report();
}

public class ReportingService : IReportingService
{
    public void Report()
    {
        WriteLine("Here is your report!");
    }
}