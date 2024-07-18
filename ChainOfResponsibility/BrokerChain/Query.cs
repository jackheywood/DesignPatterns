namespace ChainOfResponsibility.BrokerChain;

public class Query(string creatureName, Query.Argument whatToQuery, int value)
{
    public enum Argument
    {
        Attack,
        Defence,
    }

    public readonly string CreatureName = creatureName;
    public readonly Argument WhatToQuery = whatToQuery;
    public int Value = value;
}