using System.Text;
using ChainOfResponsibility.ChainOfResponsibilityExercise.Creatures;

namespace ChainOfResponsibility.ChainOfResponsibilityExercise;

public class Game
{
    private readonly List<Creature> _creatures = [];

    public IEnumerable<Creature> GetCreatures()
    {
        return _creatures;
    }

    public void AddCreature(Creature creature)
    {
        _creatures.Add(creature);
    }

    public void RemoveCreature(Creature creature)
    {
        if (_creatures.Contains(creature)) _creatures.RemoveAt(_creatures.IndexOf(creature));
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var creature in _creatures)
        {
            sb.AppendLine(creature.ToString());
        }

        return sb.ToString();
    }
}