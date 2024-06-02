using Singleton.SimpleSingleton;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleSingleton())
    .Build();

await runner.RunAsync();