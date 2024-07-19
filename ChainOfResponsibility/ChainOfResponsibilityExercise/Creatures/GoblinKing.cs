namespace ChainOfResponsibility.ChainOfResponsibilityExercise.Creatures;

public class GoblinKing(Game game) : Goblin(3, 3, game)
{
    protected override void Query(object source, StatQuery query)
    {
        if (ReferenceEquals(source, this)) return;
        if (query.Stat == Stat.Attack) query.Result += 1;
        base.Query(source, query);
    }
}