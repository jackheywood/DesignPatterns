namespace ChainOfResponsibility.MethodChain.Modifiers;

public class IncreaseDefenceModifier(Creature creature, int amount) : CreatureModifier(creature)
{
    public override void Handle()
    {
        WriteLine($"Increasing {Creature.Name}'s defence by {amount}");
        Creature.Defence += amount;
        base.Handle();
    }
}