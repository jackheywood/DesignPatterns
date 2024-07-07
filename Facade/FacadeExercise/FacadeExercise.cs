using Utilities;

namespace Facade.FacadeExercise;

public class FacadeExercise() : ConsoleProgram("Facade Exercise")
{
    public override Task RunAsync()
    {
        var magicSquareGenerator = new MagicSquareGenerator();

        var magicSquare2 = magicSquareGenerator.Generate(2);
        var magicSquare3 = magicSquareGenerator.Generate(3);
        var magicSquare4 = magicSquareGenerator.Generate(4);

        WriteSquare(magicSquare2);
        WriteSquare(magicSquare3);
        WriteSquare(magicSquare4);

        return Task.CompletedTask;
    }

    private static void WriteSquare(List<List<int>> square)
    {
        WriteLine($"Magic square of size {square.Count}:");
        foreach (var row in square)
        {
            foreach (var col in row)
            {
                Write($"{col} ");
            }

            WriteLine();
        }

        WriteLine();
    }
}