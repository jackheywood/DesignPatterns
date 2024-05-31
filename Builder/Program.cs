using Builder.FluentInheritance;
using Builder.SimpleFluent;
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
    WriteLine("Any other key - Quit");
    WriteLine();

    var input = ReadKey();

    WriteLine();
    WriteLine();

    return input.Key;
}