using Builder.FacetedBuilder.Builders;
using Utilities;
using static System.Console;

namespace Builder.FacetedBuilder;

public class FacetedBuilder() : ConsoleProgram("Faceted Builder")
{
    public override Task RunAsync()
    {
        Person person = new PersonBuilder()
            .Works.At("Consulting").AsA("Detective").Earning(100000)
            .Lives.At("221B Baker Street").In("London").WithPostcode("NW1 6XE");

        WriteLine(person);

        return Task.CompletedTask;
    }
}