namespace ChainOfResponsibility.BrokerChain.Modifiers;

public abstract class CreatureModifier : IDisposable
{
    private readonly Game _game;
    protected readonly Creature Creature;

    protected CreatureModifier(Game game, Creature creature)
    {
        _game = game;
        Creature = creature;
        _game.Queries += Handle;
    }

    public virtual void Dispose()
    {
        _game.Queries -= Handle;
    }

    protected abstract void Handle(object? sender, Query query);
}