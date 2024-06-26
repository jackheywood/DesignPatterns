﻿namespace Adapter.GenericValueAdapter;

public interface IInteger
{
    int Value { get; }
}

public class Dimensions
{
    public class Two : IInteger
    {
        public int Value => 2;
    }

    public class Three : IInteger
    {
        public int Value => 3;
    }
}