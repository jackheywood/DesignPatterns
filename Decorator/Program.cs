using Decorator.CustomStringBuilder;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new CustomStringBuilder())
    .Build();

await runner.RunAsync();