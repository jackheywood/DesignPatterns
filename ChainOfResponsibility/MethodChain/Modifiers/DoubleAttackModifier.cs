namespace ChainOfResponsibility.MethodChain.Modifiers;

public class DoubleAttackModifier(Creature creature) : CreatureModifier(creature)
{
    public override void Handle()
    {
        WriteLine($"Doubling {Creature.Name}'s attack");
        Creature.Attack *= 2;
        base.Handle();
    }
}