using Utilities;
using static System.Console;

namespace Composite.CompositeSpecification;

public class CompositeSpecification() : ConsoleProgram("Composite Specification")
{
    public override Task RunAsync()
    {
        var positiveSpec = new PositiveSpecification();
        var negativeSpec = new NegativeSpecification();

        var andSpec = new AndSpecification<int>(positiveSpec, negativeSpec);
        var orSpec = new OrSpecification<int>(positiveSpec, negativeSpec);

        int[] testValues = [-5, 0, 3];


        foreach (var testValue in testValues)
        {
            WriteLine($"Testing value: {testValue}");
            Write($"Positive: {positiveSpec.IsSatisfied(testValue)}; ");
            Write($"Negative: {negativeSpec.IsSatisfied(testValue)}; ");
            Write($"Both: {andSpec.IsSatisfied(testValue)}; ");
            WriteLine($"Either: {orSpec.IsSatisfied(testValue)}\n");
        }

        return Task.CompletedTask;
    }
}