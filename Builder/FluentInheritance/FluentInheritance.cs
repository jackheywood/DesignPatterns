namespace Builder.FluentInheritance;

using static Console;

public static class FluentInheritance
{
    public static void Run()
    {
        var me = Person.New
            .Called("Jack")
            .WorksAsA("Developer")
            .Build();

        WriteLine(me);
    }
}