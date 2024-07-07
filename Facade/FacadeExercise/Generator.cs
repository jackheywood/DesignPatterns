namespace Facade.FacadeExercise;

public class Generator
{
    private static readonly Random Random = new();

    public List<int> Generate(int count)
    {
        return Enumerable.Range(0, count)
            .Select(_ => Random.Next(1, 6))
            .ToList();
    }
}