using ChainOfResponsibility.BrokerChain.Modifiers;
using Utilities;

namespace ChainOfResponsibility.BrokerChain;

public class BrokerChain() : ConsoleProgram("Broker Chain")
{
    public override Task RunAsync()
    {
        var game = new Game();
        var goblin = new Creature(game, "Goblin", 2, 2);

        WriteLine(goblin);

        using (new DoubleAttackModifier(game, goblin))
        {
            WriteLine(goblin);

            using (new IncreaseDefenceModifier(game, goblin, 4))
            {
                WriteLine(goblin);
            }

            WriteLine(goblin);
        }

        WriteLine(goblin);

        return Task.CompletedTask;
    }
}