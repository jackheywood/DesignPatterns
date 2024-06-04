using Bridge.BridgeExample;
using Bridge.DependencyInjection;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new BridgeExample())
    .WithProgram(new DependencyInjection())
    .Build();

await runner.RunAsync();