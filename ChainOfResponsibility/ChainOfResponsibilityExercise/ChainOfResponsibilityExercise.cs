using ChainOfResponsibility.ChainOfResponsibilityExercise.Creatures;
using Utilities;

namespace ChainOfResponsibility.ChainOfResponsibilityExercise;

public class ChainOfResponsibilityExercise() : ConsoleProgram("Chain of Responsibility Exercise")
{
    public override Task RunAsync()
    {
        var game = new Game();
        
        var goblin1 = new Goblin(game);
        var goblin2 = new Goblin(game);
        var goblin3 = new Goblin(game);
        var goblinKing = new GoblinKing(game);

        game.AddCreature(goblin1);
        game.AddCreature(goblin2);

        WriteLine(game);

        game.AddCreature(goblin3);
        game.AddCreature(goblinKing);

        WriteLine(game);

        game.RemoveCreature(goblin2);
        game.RemoveCreature(goblin3);

        WriteLine(game);

        return Task.CompletedTask;
    }
}