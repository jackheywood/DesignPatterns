using ChainOfResponsibility.MethodChain.Modifiers;
using Utilities;

namespace ChainOfResponsibility.MethodChain;

public class MethodChain() : ConsoleProgram("Method Chain")
{
    public override Task RunAsync()
    {
        var goblin = new Creature("Goblin", 2, 2);

        WriteLine(goblin);

        var root = new CreatureModifier(goblin);
        
        root.Add(new DoubleAttackModifier(goblin));
        root.Add(new IncreaseDefenceModifier(goblin, 3));
        root.Add(new NoBonusesModifier(goblin));
        root.Add(new DoubleAttackModifier(goblin));
        
        root.Handle();

        WriteLine(goblin);

        return Task.CompletedTask;
    }
}