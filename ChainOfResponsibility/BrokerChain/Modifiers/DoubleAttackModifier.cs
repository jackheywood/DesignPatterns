namespace ChainOfResponsibility.BrokerChain.Modifiers;

public class DoubleAttackModifier(Game game, Creature creature) : CreatureModifier(game, creature)
{
    public override void Dispose()
    {
        WriteLine($"Removing double attack buff from {Creature.Name}");
        base.Dispose();
    }

    protected override void Handle(object? sender, Query query)
    {
        if (query.CreatureName == Creature.Name && query.WhatToQuery == Query.Argument.Attack)
        {
            WriteLine($"Doubling {Creature.Name}'s attack");
            query.Value *= 2;
        }
    }
}