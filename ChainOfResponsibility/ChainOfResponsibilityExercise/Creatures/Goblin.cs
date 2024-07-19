namespace ChainOfResponsibility.ChainOfResponsibilityExercise.Creatures;

public class Goblin : Creature
{
    public Goblin(Game game) : base(1, 1, game)
    { }

    protected Goblin(int baseAttack, int baseDefense, Game game)
        : base(baseAttack, baseDefense, game)
    { }

    protected override void Query(object source, StatQuery query)
    {
        if (ReferenceEquals(source, this)) return;
        if (query.Stat == Stat.Defense) query.Result += 1;
    }
}