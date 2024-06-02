using Singleton.DependencyInjection;
using Singleton.Monostate;
using Singleton.SimpleSingleton;
using Singleton.TestabilityIssues;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleSingleton())
    .WithProgram(new TestabilityIssues())
    .WithProgram(new DependencyInjection())
    .WithProgram(new Monostate())
    .Build();

await runner.RunAsync();