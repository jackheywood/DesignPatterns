﻿using System.Text;

namespace Decorator.CustomStringBuilder;

public class CodeBuilder
{
    private readonly StringBuilder _builder = new();

    public int Capacity
    {
        get => _builder.Capacity;
        set => _builder.Capacity = value;
    }

    public char this[int index]
    {
        get => _builder[index];
        set => _builder[index] = value;
    }

    public int Length
    {
        get => _builder.Length;
        set => _builder.Length = value;
    }

    public int MaxCapacity => _builder.MaxCapacity;

    public CodeBuilder Append(bool value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(byte value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(char value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(char value, int repeatCount)
    {
        _builder.Append(value, repeatCount);
        return this;
    }

    public CodeBuilder Append(char[] value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(char[] value, int startIndex, int charCount)
    {
        _builder.Append(value, startIndex, charCount);
        return this;
    }

    public CodeBuilder Append(decimal value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(double value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(IFormatProvider provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _builder.Append(provider, ref handler);
        return this;
    }

    public CodeBuilder Append(short value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(int value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(long value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(object value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(ReadOnlyMemory<char> value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(ReadOnlySpan<char> value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(sbyte value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(float value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(string value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(string value, int startIndex, int count)
    {
        _builder.Append(value, startIndex, count);
        return this;
    }

    public CodeBuilder Append(CodeBuilder value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(CodeBuilder value, int startIndex, int count)
    {
        _builder.Append(value._builder, startIndex, count);
        return this;
    }

    public CodeBuilder Append(ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _builder.Append(ref handler);
        return this;
    }

    public CodeBuilder Append(ushort value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(uint value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder Append(ulong value)
    {
        _builder.Append(value);
        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
    {
        _builder.AppendFormat(provider, format, arg0);
        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1)
    {
        _builder.AppendFormat(provider, format, arg0, arg1);
        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
    {
        _builder.AppendFormat(provider, format, arg0, arg1, arg2);
        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
    {
        _builder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeBuilder AppendFormat(string format, object arg0)
    {
        _builder.AppendFormat(format, arg0);
        return this;
    }

    public CodeBuilder AppendFormat(string format, object arg0, object arg1)
    {
        _builder.AppendFormat(format, arg0, arg1);
        return this;
    }

    public CodeBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
    {
        _builder.AppendFormat(format, arg0, arg1, arg2);
        return this;
    }

    public CodeBuilder AppendFormat(string format, params object[] args)
    {
        _builder.AppendFormat(format, args);
        return this;
    }

    public CodeBuilder AppendFormat<TArg0>(IFormatProvider provider, CompositeFormat format, TArg0 arg0)
    {
        _builder.AppendFormat(provider, format, arg0);
        return this;
    }

    public CodeBuilder AppendFormat<TArg0, TArg1>(IFormatProvider provider, CompositeFormat format, TArg0 arg0,
        TArg1 arg1)
    {
        _builder.AppendFormat(provider, format, arg0, arg1);
        return this;
    }

    public CodeBuilder AppendFormat<TArg0, TArg1, TArg2>(IFormatProvider provider, CompositeFormat format, TArg0 arg0,
        TArg1 arg1, TArg2 arg2)
    {
        _builder.AppendFormat(provider, format, arg0, arg1, arg2);
        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider provider, CompositeFormat format, params object[] args)
    {
        _builder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider provider, CompositeFormat format, ReadOnlySpan<object> args)
    {
        _builder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeBuilder AppendJoin(char separator, params object[] values)
    {
        _builder.AppendJoin(separator, values);
        return this;
    }

    public CodeBuilder AppendJoin(char separator, params string[] values)
    {
        _builder.AppendJoin(separator, values);
        return this;
    }

    public CodeBuilder AppendJoin(string separator, params object[] values)
    {
        _builder.AppendJoin(separator, values);
        return this;
    }

    public CodeBuilder AppendJoin(string separator, params string[] values)
    {
        _builder.AppendJoin(separator, values);
        return this;
    }

    public CodeBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
    {
        _builder.AppendJoin(separator, values);
        return this;
    }

    public CodeBuilder AppendJoin<T>(string separator, IEnumerable<T> values)
    {
        _builder.AppendJoin(separator, values);
        return this;
    }

    public CodeBuilder AppendLine()
    {
        _builder.AppendLine();
        return this;
    }

    public CodeBuilder AppendLine(IFormatProvider provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _builder.AppendLine(provider, ref handler);
        return this;
    }

    public CodeBuilder AppendLine(string value)
    {
        _builder.AppendLine(value);
        return this;
    }

    public CodeBuilder AppendLine(ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _builder.AppendLine(ref handler);
        return this;
    }

    public CodeBuilder Clear()
    {
        _builder.Clear();
        return this;
    }

    public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
    {
        _builder.CopyTo(sourceIndex, destination, destinationIndex, count);
    }

    public void CopyTo(int sourceIndex, Span<char> destination, int count)
    {
        _builder.CopyTo(sourceIndex, destination, count);
    }

    public int EnsureCapacity(int capacity) => _builder.EnsureCapacity(capacity);

    public bool Equals(ReadOnlySpan<char> span) => _builder.Equals(span);

    public bool Equals(CodeBuilder cb) => _builder.Equals(cb._builder);

    public StringBuilder.ChunkEnumerator GetChunks() => _builder.GetChunks();

    public CodeBuilder Insert(int index, bool value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, byte value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, char value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, char[] value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, char[] value, int startIndex, int charCount)
    {
        _builder.Insert(index, value, startIndex, charCount);
        return this;
    }

    public CodeBuilder Insert(int index, decimal value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, double value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, short value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, int value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, long value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, object value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, ReadOnlySpan<char> value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, sbyte value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, float value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, string value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, string value, int count)
    {
        _builder.Insert(index, value, count);
        return this;
    }

    public CodeBuilder Insert(int index, ushort value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, uint value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Insert(int index, ulong value)
    {
        _builder.Insert(index, value);
        return this;
    }

    public CodeBuilder Remove(int startIndex, int length)
    {
        _builder.Remove(startIndex, length);
        return this;
    }

    public CodeBuilder Replace(char oldChar, char newChar)
    {
        _builder.Replace(oldChar, newChar);
        return this;
    }

    public CodeBuilder Replace(char oldChar, char newChar, int startIndex, int count)
    {
        _builder.Replace(oldChar, newChar, startIndex, count);
        return this;
    }

    public CodeBuilder Replace(string oldValue, string newValue)
    {
        _builder.Replace(oldValue, newValue);
        return this;
    }

    public CodeBuilder Replace(string oldValue, string newValue, int startIndex, int count)
    {
        _builder.Replace(oldValue, newValue, startIndex, count);
        return this;
    }

    public string ToString(int startIndex, int length) => _builder.ToString(startIndex, length);

    public override string ToString() => _builder.ToString();
}