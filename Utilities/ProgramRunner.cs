using static System.Console;

namespace Utilities;

public class ProgramRunner
{
    public readonly Dictionary<ConsoleKey, ConsoleProgram> ConsolePrograms = new();

    public async Task RunAsync()
    {
        while (true)
        {
            var key = PromptForKey();

            if (!ConsolePrograms.TryGetValue(key, out var program))
            {
                WriteLine("Closing program...");
                return;
            }

            WriteLine($" - {program.Name}\n");
            await program.RunAsync();

            WriteLine("\nPress ENTER to quit or any other key to run again...\n");
            if (ReadKey().Key == ConsoleKey.Enter)
            {
                WriteLine("Closing program...");
                return;
            }
            WriteLine("\n");
        }
    }

    private ConsoleKey PromptForKey()
    {
        WriteLine("Which program would you like to run?\n");

        foreach (var consoleProgram in ConsolePrograms)
            WriteLine($"{consoleProgram.Key.ToString()[1]} - {consoleProgram.Value.Name}");

        WriteLine("Any other key - Quit\n");

        return ReadKey().Key;
    }
}