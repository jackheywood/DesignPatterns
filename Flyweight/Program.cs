using Flyweight.FlyweightExercise;
using Flyweight.TextFormatting;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new TextFormatting())
    .WithProgram(new FlyweightExercise())
    .Build();

await runner.RunAsync();