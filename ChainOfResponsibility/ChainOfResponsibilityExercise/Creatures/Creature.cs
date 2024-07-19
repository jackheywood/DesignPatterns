namespace ChainOfResponsibility.ChainOfResponsibilityExercise.Creatures;

public abstract class Creature(int baseAttack, int baseDefense, Game game)
{
    public int Attack
    {
        get
        {
            var query = new StatQuery(Stat.Attack, baseAttack);
            ProcessQuery(query);
            return query.Result;
        }
    }

    public int Defense
    {
        get
        {
            var query = new StatQuery(Stat.Defense, baseDefense);
            ProcessQuery(query);
            return query.Result;
        }
    }

    public override string ToString()
    {
        return $"{GetType().Name} - {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
    }

    protected abstract void Query(object source, StatQuery query);

    private void ProcessQuery(StatQuery query)
    {
        foreach (var creature in game.GetCreatures())
        {
            creature.Query(this, query);
        }
    }
}