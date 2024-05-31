using Builder.Faceted.Builders;
using static System.Console;

namespace Builder.Faceted;

public static class Faceted
{
    public static void Run()
    {
        Person person = new PersonBuilder()
            .Works.At("Consulting").AsA("Detective").Earning(100000)
            .Lives.At("221B Baker Street").In("London").WithPostcode("NW1 6XE");

        WriteLine(person);
    }
}