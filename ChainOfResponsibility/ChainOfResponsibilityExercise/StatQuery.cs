namespace ChainOfResponsibility.ChainOfResponsibilityExercise;

public class StatQuery
{
    public readonly Stat Stat;
    public int Result;

    public StatQuery(Stat stat, int result)
    {
        Result = result;
        Stat = stat;
    }
}