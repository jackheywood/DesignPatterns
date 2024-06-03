using Adapter.SimpleAdapter;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleAdapter())
    .Build();

await runner.RunAsync();