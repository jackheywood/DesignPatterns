using Bridge.BridgeExample;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new BridgeExample())
    .Build();

await runner.RunAsync();