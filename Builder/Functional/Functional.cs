using Builder.Functional.Builders;
using Builder.Functional.Extensions;
using static System.Console;

namespace Builder.Functional;

public static class Functional
{
    public static void Run()
    {
        var person = new PersonBuilder()
            .Called("Jack")
            .WorksAs("Developer")
            .Build();

        WriteLine(person);
    }
}