using Builder.Faceted;
using Builder.FluentInheritance;
using Builder.Functional;
using Builder.SimpleFluent;
using Builder.Stepwise;
using static System.Console;

Run();
return;

void Run()
{
    while (true)
    {
        var inputKey = PromptForKey();

        switch (inputKey)
        {
            case ConsoleKey.D1:
                SimpleFluent.Run();
                break;
            case ConsoleKey.D2:
                FluentInheritance.Run();
                break;
            case ConsoleKey.D3:
                Stepwise.Run();
                break;
            case ConsoleKey.D4:
                Functional.Run();
                break;
            case ConsoleKey.D5:
                Faceted.Run();
                break;
            default:
                WriteLine("Closing program...");
                return;
        }

        WriteLine();
    }
}

ConsoleKey PromptForKey()
{
    WriteLine("Which program would you like to run?");
    WriteLine();
    WriteLine("1 - Simple Fluent Builder");
    WriteLine("2 - Fluent Builder Inheritance");
    WriteLine("3 - Stepwise Builder");
    WriteLine("4 - Functional Builder");
    WriteLine("5 - Faceted Builder");
    WriteLine("Any other key - Quit");
    WriteLine();

    var input = ReadKey();

    WriteLine();
    WriteLine();

    return input.Key;
}