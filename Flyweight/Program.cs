using Flyweight.TextFormatting;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new TextFormatting())
    .Build();

await runner.RunAsync();