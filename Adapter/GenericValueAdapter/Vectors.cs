// ReSharper disable InconsistentNaming

namespace Adapter.GenericValueAdapter;

public class Vector<TSelf, T, D>
    where D : IInteger, new()
    where TSelf : Vector<TSelf, T, D>, new()
{
    private T[] _data;

    protected Vector()
    {
        _data = new T[new D().Value];
    }

    protected T this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }

    public static TSelf Create(params T[] values)
    {
        var result = new TSelf();
        var requiredSize = new D().Value;
        result._data = new T[requiredSize];

        var providedSize = values.Length;

        for (var i = 0; i < Math.Min(requiredSize, providedSize); i++)
        {
            result._data[i] = values[i];
        }

        return result;
    }

    public override string ToString() => $"({string.Join(", ", _data)})";
}

public class VectorOfInt<TSelf, D> : Vector<TSelf, int, D>
    where D : IInteger, new()
    where TSelf : VectorOfInt<TSelf, D>, new()
{
    public static TSelf operator +(VectorOfInt<TSelf, D> lhs, VectorOfInt<TSelf, D> rhs)
    {
        var result = new TSelf();
        var dimensions = new D().Value;
        for (var i = 0; i < dimensions; i++) result[i] = lhs[i] + rhs[i];
        return result;
    }
}

public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
    where D : IInteger, new()
    where TSelf : VectorOfFloat<TSelf, D>, new()
{
    public static TSelf operator +(VectorOfFloat<TSelf, D> lhs, VectorOfFloat<TSelf, D> rhs)
    {
        var result = new TSelf();
        var dimensions = new D().Value;
        for (var i = 0; i < dimensions; i++) result[i] = lhs[i] + rhs[i];
        return result;
    }
}

public class Vector2I : VectorOfInt<Vector2I, Dimensions.Two>;

public class Vector3F : VectorOfFloat<Vector3F, Dimensions.Three>;