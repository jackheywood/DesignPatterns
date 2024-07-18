namespace Proxy.BitFragging;

public class TwoBitSet(ulong data)
{
    // 64 bits --> 32 values
    public byte this[int index]
    {
        get
        {
            var shift = index << 1;
            ulong mask = 0b11U << shift;
            return (byte)((data & mask) >> shift);
        }
    }
}