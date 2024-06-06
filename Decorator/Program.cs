using Decorator.AdapterDecorator;
using Decorator.CustomStringBuilder;
using Decorator.DefaultInterfaceMembers;
using Decorator.DynamicDecorator;
using Decorator.MultipleInheritanceInterfaces;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new CustomStringBuilder())
    .WithProgram(new AdapterDecorator())
    .WithProgram(new MultipleInheritance())
    .WithProgram(new DefaultInterfaceMembers())
    .WithProgram(new DynamicDecorator())
    .Build();

await runner.RunAsync();