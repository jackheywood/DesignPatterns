using static System.Console;

namespace ConsoleRunner;

public class ProgramRunner
{
    public readonly Dictionary<ConsoleKey, ConsoleProgram> ConsolePrograms = new();

    public void Run()
    {
        while (true)
        {
            var key = PromptForKey();

            if (!ConsolePrograms.TryGetValue(key, out var program))
            {
                WriteLine("Closing program...");
                return;
            }

            program.Run();

            WriteLine();
        }
    }

    private ConsoleKey PromptForKey()
    {
        WriteLine("Which program would you like to run?\n");

        foreach (var consoleProgram in ConsolePrograms)
        {
            WriteLine($"{consoleProgram.Key.ToString()[1]} - {consoleProgram.Value.Name}");
        }

        WriteLine("Any other key - Quit\n");

        var input = ReadKey();

        WriteLine("\n");

        return input.Key;
    }
}