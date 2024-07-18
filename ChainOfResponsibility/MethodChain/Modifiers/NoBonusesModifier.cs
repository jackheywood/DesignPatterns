namespace ChainOfResponsibility.MethodChain.Modifiers;

public class NoBonusesModifier(Creature creature) : CreatureModifier(creature)
{
    public override void Handle()
    { }
}