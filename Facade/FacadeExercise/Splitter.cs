namespace Facade.FacadeExercise;

public class Splitter
{
    public List<List<int>> Split(List<List<int>> array)
    {
        var result = new List<List<int>>();

        result.AddRange(GetRows(array));
        result.AddRange(GetColumns(array));
        result.AddRange(GetDiagonals(array));

        return result;
    }

    private static IEnumerable<List<int>> GetRows(List<List<int>> array)
    {
        foreach (var r in array)
        {
            var row = new List<int>();

            for (var c = 0; c < array[0].Count; c++)
            {
                row.Add(r[c]);
            }

            yield return row;
        }
    }

    private static IEnumerable<List<int>> GetColumns(List<List<int>> array)
    {
        for (var c = 0; c < array[0].Count; c++)
        {
            yield return array.Select(r => r[c]).ToList();
        }
    }

    private static IEnumerable<List<int>> GetDiagonals(List<List<int>> array)
    {
        var diagonal1 = new List<int>();
        var diagonal2 = new List<int>();

        for (var c = 0; c < array[0].Count; c++)
        {
            for (var r = 0; r < array.Count; r++)
            {
                if (c == r) diagonal1.Add(array[r][c]);
                var r2 = array.Count - r - 1;
                if (c == r2) diagonal2.Add(array[r][c]);
            }
        }

        return [diagonal1, diagonal2];
    }
}