using Decorator.AdapterDecorator;
using Decorator.CustomStringBuilder;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new CustomStringBuilder())
    .WithProgram(new AdapterDecorator())
    .Build();

await runner.RunAsync();