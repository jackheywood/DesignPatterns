using Builder.FunctionalBuilder.Builders;
using Builder.FunctionalBuilder.Extensions;
using Utilities;

namespace Builder.FunctionalBuilder;

public class FunctionalBuilder() : ConsoleProgram("Functional Builder")
{
    public override Task RunAsync()
    {
        var person = new PersonBuilder()
            .Called("Jack")
            .WorksAs("Developer")
            .Build();

        WriteLine(person);

        return Task.CompletedTask;
    }
}