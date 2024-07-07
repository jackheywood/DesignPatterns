namespace Facade.FacadeExercise;

public class Verifier
{
    public bool Verify(List<List<int>> array)
    {
        if (array.Count == 0) return false;
        var expected = array.First().Sum();
        return array.All(a => a.Sum() == expected);
    }
}