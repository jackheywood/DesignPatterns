namespace ChainOfResponsibility.BrokerChain;

public class Creature(Game game, string name, int attack, int defence)
{
    public string Name = name;

    public int Attack
    {
        get
        {
            var query = new Query(Name, Query.Argument.Attack, attack);
            game.PerformQuery(this, query);
            return query.Value;
        }
    }

    public int Defence
    {
        get
        {
            var query = new Query(Name, Query.Argument.Defence, defence);
            game.PerformQuery(this, query);
            return query.Value;
        }
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defence)}: {Defence}";
    }
}