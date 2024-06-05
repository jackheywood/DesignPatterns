using Decorator.AdapterDecorator;
using Decorator.CustomStringBuilder;
using Decorator.MultipleInheritanceInterfaces;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new CustomStringBuilder())
    .WithProgram(new AdapterDecorator())
    .WithProgram(new MultipleInheritance())
    .Build();

await runner.RunAsync();