using static System.Console;

namespace Utilities;

public class ProgramRunner
{
    public readonly List<ConsoleProgram> ConsolePrograms = [];

    public async Task RunAsync()
    {
        while (true)
        {
            var index = PromptForIndex();
            var program = ConsolePrograms.ElementAtOrDefault(index);

            if (program is null)
            {
                WriteLine(" - Closing program...");
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

    private int PromptForIndex()
    {
        WriteLine("Which program would you like to run?\n");

        for (var i = 0; i < ConsolePrograms.Count; i++)
        {
            WriteLine($"{i + 1} - {ConsolePrograms[i].Name}");
        }

        WriteLine("Any other key - Quit\n");

        var input = ReadKey().KeyChar;

        if (char.IsDigit(input))
        {
            return int.Parse(input.ToString()) - 1;
        }

        return -1;
    }
}