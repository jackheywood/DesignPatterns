using Singleton.DependencyInjection;
using Singleton.SimpleSingleton;
using Singleton.TestabilityIssues;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleSingleton())
    .WithProgram(new TestabilityIssues())
    .WithProgram(new DependencyInjection())
    .Build();

await runner.RunAsync();