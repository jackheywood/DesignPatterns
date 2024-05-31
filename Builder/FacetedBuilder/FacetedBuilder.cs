using Builder.FacetedBuilder.Builders;
using Utilities;
using static System.Console;

namespace Builder.FacetedBuilder;

public class FacetedBuilder : ConsoleProgram
{
    public FacetedBuilder()
    {
        Name = "Faceted Builder";
    }

    public override void Run()
    {
        Person person = new PersonBuilder()
            .Works.At("Consulting").AsA("Detective").Earning(100000)
            .Lives.At("221B Baker Street").In("London").WithPostcode("NW1 6XE");

        WriteLine(person);
    }
}