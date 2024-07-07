namespace Facade.FacadeExercise;

public class MagicSquareGenerator
{
    private readonly Generator _generator = new();
    private readonly Splitter _splitter = new();
    private readonly Verifier _verifier = new();

    public List<List<int>> Generate(int size)
    {
        while (true)
        {
            var square = Enumerable.Range(0, size)
                .Select(_ => _generator.Generate(size))
                .ToList();

            if (_verifier.Verify(_splitter.Split(square))) return square;
        }
    }
}