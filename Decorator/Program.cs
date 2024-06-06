using Decorator.AdapterDecorator;
using Decorator.CustomStringBuilder;
using Decorator.DecoratorCycles;
using Decorator.DefaultInterfaceMembers;
using Decorator.DependencyInjection;
using Decorator.DynamicDecorator;
using Decorator.MultipleInheritanceInterfaces;
using Decorator.StaticDecorator;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new CustomStringBuilder())
    .WithProgram(new AdapterDecorator())
    .WithProgram(new MultipleInheritance())
    .WithProgram(new DefaultInterfaceMembers())
    .WithProgram(new DynamicDecorator())
    .WithProgram(new DecoratorCycles())
    .WithProgram(new StaticDecorator())
    .WithProgram(new DependencyInjection())
    .Build();

await runner.RunAsync();