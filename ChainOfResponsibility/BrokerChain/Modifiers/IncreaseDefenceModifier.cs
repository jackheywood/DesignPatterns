namespace ChainOfResponsibility.BrokerChain.Modifiers;

public class IncreaseDefenceModifier(Game game, Creature creature, int amount) : CreatureModifier(game, creature)
{
    public override void Dispose()
    {
        WriteLine($"Removing defence buff from {Creature.Name}");
        base.Dispose();
    }

    protected override void Handle(object? sender, Query query)
    {
        if (query.CreatureName == Creature.Name && query.WhatToQuery == Query.Argument.Defence)
        {
            WriteLine($"Increasing {Creature.Name}'s defence by {amount}");
            query.Value += amount;
        }
    }
}