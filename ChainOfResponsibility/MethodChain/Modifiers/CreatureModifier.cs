namespace ChainOfResponsibility.MethodChain.Modifiers;

public class CreatureModifier(Creature creature)
{
    protected Creature Creature = creature;
    protected CreatureModifier? Next; // linked list

    public void Add(CreatureModifier modifier)
    {
        if (Next != null) Next.Add(modifier);
        else Next = modifier;
    }

    public virtual void Handle() => Next?.Handle();
}