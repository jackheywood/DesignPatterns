using System.Collections;

namespace Composite.CompositeExercise;

public interface IValueContainer : IEnumerable<int>;

public class SingleValue : IValueContainer
{
    public int Value;

    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public override string ToString() => $"Value: {Value}";
}

public class ManyValues : List<int>, IValueContainer
{
    public override string ToString() => $"Many values: {string.Join(", ", this)}";
}