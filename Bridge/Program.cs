using Bridge.BridgeExample;
using Bridge.BridgeExercise;
using Bridge.DependencyInjection;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new BridgeExample())
    .WithProgram(new DependencyInjection())
    .WithProgram(new BridgeExercise())
    .Build();

await runner.RunAsync();