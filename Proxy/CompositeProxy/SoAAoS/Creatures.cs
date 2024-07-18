namespace Proxy.CompositeProxy.SoAAoS;

public class Creatures
{
    private readonly byte[] _age;
    private readonly int _size;
    private readonly int[] _x;
    private readonly int[] _y;

    public Creatures(int size)
    {
        _size = size;
        _age = new byte[size];
        _x = new int[size];
        _y = new int[size];

        var random = new Random();
        random.NextBytes(_age);

        for (var i = 0; i < size; i++)
        {
            _x[i] = random.Next();
            _y[i] = random.Next();
        }
    }

    public IEnumerator<CreatureProxy> GetEnumerator()
    {
        for (var i = 0; i < _size; i++)
        {
            yield return new CreatureProxy(this, i);
        }
    }

    public readonly struct CreatureProxy(Creatures creatures, int index)
    {
        public ref byte Age => ref creatures._age[index];
        public ref int X => ref creatures._x[index];
        public ref int Y => ref creatures._y[index];
    }
}