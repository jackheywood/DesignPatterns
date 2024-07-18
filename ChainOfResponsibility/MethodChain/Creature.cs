namespace ChainOfResponsibility.MethodChain;

public class Creature(string name, int attack, int defence)
{
    public readonly string Name = name;
    public int Attack = attack;
    public int Defence = defence;

    public override string ToString()
    {
        return $"Name: {Name}, Attack: {Attack}, Defence: {Defence}";
    }
}